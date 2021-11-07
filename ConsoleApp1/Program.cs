using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmPointer = System.IntPtr;
using SmcConn = System.IntPtr;
using SmProp = System.IntPtr;
using IcePointer = System.IntPtr;
using IceConn = System.IntPtr;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IDisposable k = null;
            Task.Run(() => { k = new XsmpClient(); });
            Console.ReadLine();
            k?.Dispose();
        }

        public unsafe class XsmpClient : IDisposable
        {
            private const ulong SmcSaveYourselfProcMask = (1L << 0);
            private const ulong SmcDieProcMask = (1L << 1);
            private const ulong SmcSaveCompleteProcMask = (1L << 2);
            private const ulong SmcShutdownCancelledProcMask = (1L << 3);

            private readonly IntPtr _smcConn;
 
            static bool   xsmp_save_yourself;
            static bool   xsmp_shutdown;

            public XsmpClient()
            {
                var errorBuf = new byte[255];

                var x = new SmcCallbacks
                {
                    shutdown_cancelled = Marshal.GetFunctionPointerForDelegate(SmcShutdownCancelledDelegate),
                    die = Marshal.GetFunctionPointerForDelegate(SmcDieDelegate),
                    save_yourself = Marshal.GetFunctionPointerForDelegate(SmcSaveYourselfProcDelegate),
                    save_complete = Marshal.GetFunctionPointerForDelegate(SmcSaveCompleteDelegate)
                };
                
                if (IceAddConnectionWatch(Marshal.GetFunctionPointerForDelegate(IceWatchProcDelegate),
                    IntPtr.Zero) == 0)
                {
                    Console.WriteLine("XSMP ICE connection watch failed\n");
                    return;
                }

                fixed (byte* p = errorBuf)
                {
                    var ptr = (IntPtr) p;

                    _smcConn = SmcOpenConnection(IntPtr.Zero,
                        IntPtr.Zero, 1, 0,
                        SmcSaveYourselfProcMask |
                        SmcSaveCompleteProcMask |
                        SmcShutdownCancelledProcMask |
                        SmcDieProcMask,
                        &x,
                        out var tt1, out var ep2, errorBuf.Length, ptr);
                }

                if (_smcConn == IntPtr.Zero)
                {
                    var errorString = Encoding.ASCII.GetString(errorBuf);
                    Console.WriteLine($"Error! {errorString}");
                }

                xsmp_iceconn = SmcGetIceConnection(_smcConn);

                Task.Run(() =>
                {
                    while (true)
                    {
                        HandleRequests();
                    }
                });
            }


            void HandleRequests()
            {

                if (IceProcessMessages(xsmp_iceconn, out var a, out var rep) == IceProcessMessagesStatus.IceProcessMessagesIOError)
                {
                    // Lost ICE
                    Console.WriteLine("XSMP lost ICE connection\n");
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("XSMP IceProcessMessages\n");
                }
            }

            public static IceConn xsmp_iceconn;
            public static readonly int dummy = 0;
            public static bool isFirstOneSaveYourselfCall ;

            public static readonly SmcSaveYourselfProc SmcSaveYourselfProcDelegate = SmcSaveYourselfHandler;
            public static readonly SmcDieProc SmcDieDelegate = SmcDieHandler;
            public static readonly SmcShutdownCancelledProc SmcShutdownCancelledDelegate = SmcShutdownCancelledHandler;
            public static readonly SmcSaveCompleteProc SmcSaveCompleteDelegate = SmcSaveCompleteHandler;
            public static readonly IceWatchProc IceWatchProcDelegate = IceWatchHandler;

            public static void SmcSaveCompleteHandler(
                SmcConn smcConn,
                SmPointer clientData
            )
            {
                Console.WriteLine("SmcSaveCompleteHandler");
            }
            public static void SmcShutdownCancelledHandler(
                SmcConn smcConn,
                SmPointer clientData
            )
            {
                Console.WriteLine("SmcShutdownCancelledHandler");
            }


            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SmcShutdownCancelledProc(
                SmcConn smcConn,
                SmPointer clientData
            );
            
            public static void SmcDieHandler(
                SmcConn smcConn,
                SmPointer clientData
            )
            {
                Console.WriteLine("SmcDieHandler");
            }

            public static void SmcSaveYourselfHandler(
                SmcConn smcConn,
                SmPointer clientData,
                int saveType,
                bool shutdown,
                int interactStyle,
                bool fast
            )
            {
                Console.WriteLine("SmcSaveYourselfHandler");

                if (isFirstOneSaveYourselfCall)
                {
                    SmcSaveYourselfDone(smcConn, true);
                }

                isFirstOneSaveYourselfCall = true;
                 
                xsmp_shutdown = shutdown;
                SmcSaveYourselfDone(smcConn, false);
            }
            
            static void IceWatchHandler(
                IceConn iceConn,
                IcePointer clientData,
                bool opening,
                IcePointer* watchData
            )
            {
                if (!opening) return;
                IceRemoveConnectionWatch(Marshal.GetFunctionPointerForDelegate(IceWatchProcDelegate), IntPtr.Zero);
            }

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void IceWatchProc(
                IceConn iceConn,
                IcePointer clientData,
                bool opening,
                IcePointer* watchData
            );

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SmcSaveYourselfProc(
                SmcConn smcConn,
                SmPointer clientData,
                int saveType,
                bool shutdown,
                int interactStyle,
                bool fast
            );

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SmcDieProc(
                SmcConn smcConn,
                SmPointer clientData
            );

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SmcSaveCompleteProc(
                SmcConn smcConn,
                SmPointer clientData
            );
 
            public struct SmProp
            {
                public byte* Name;
                public byte* Type;
                public int NumVals;
                public SmPropValue* Vals;
            }

            public struct SmPropValue
            {
                public int Length;
                public SmPointer Value;
            } 


            [StructLayout(LayoutKind.Sequential)]
            public struct SmcCallbacks
            {
                public IntPtr save_yourself;

                public SmPointer save_yourself_client_data;

                public IntPtr die;

                public SmPointer die_client_data;

                public IntPtr save_complete;

                public SmPointer save_complete_client_data;

                public IntPtr shutdown_cancelled;

                public SmPointer shutdown_cancelled_client_data;
            }

            [DllImport("libSM.so.6", CharSet = CharSet.Ansi)]
            public static extern SmcConn SmcOpenConnection(IntPtr networkId,
                IntPtr content,
                int xsmpMajorRev,
                int xsmpMinorRev,
                ulong mask,
                SmcCallbacks* callbacks,
                out string previousId,
                out IntPtr clientIdRet,
                int errorLength,
                IntPtr errorStringRet);


            public enum IceProcessMessagesStatus
            {
                IceProcessMessagesSuccess,
                IceProcessMessagesIOError,
                IceProcessMessagesConnectionClosed
            }


            public enum SmcCloseStatus
            {
                SmcClosedNow,
                SmcClosedAsap,
                SmcConnectionInUse
            }


            [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern SmcCloseStatus SmcCloseConnection(
                SmcConn smcConn,
                int count,
                string[] reasonMsgs
            );


            [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern void SmcSetProperties(
                SmcConn smcConn,
                int numProps,
                SmProp** props
            );
            
            [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern void SmcSaveYourselfDone(
                SmcConn smcConn,
                bool success
             );

             


            [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IceConn SmcGetIceConnection(
                SmcConn smcConn
            );


            [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern int IceAddConnectionWatch(
                IntPtr watchProc,
                IcePointer clientData
            );


            [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern int IceConnectionNumber(
                IntPtr iceConn
            );


            [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern int IceRemoveConnectionWatch(
                IntPtr watchProc,
                IcePointer clientData
            );
            
            


            [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IceProcessMessagesStatus IceProcessMessages(
                IceConn iceConn ,
                out IceReplyWaitInfo replyWait ,
                out bool replyReadyRet
            );

            public struct IceReplyWaitInfo
            {
                ulong sequence_of_request;
                int major_opcode_of_request;
                int minor_opcode_of_request;
                IcePointer reply;
            };


            public void Dispose()
            {
                if (_smcConn != IntPtr.Zero)
                {
                    var stat = SmcCloseConnection(_smcConn, 0, new[]
                    {
                        "Test 1",
                        "Test 2"
                    });
                }
            }
        }
    }
}