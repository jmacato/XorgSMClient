using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SmPointer = System.IntPtr;
using SmcConn = System.IntPtr;
using SmProp = System.IntPtr;

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

            public static void ShutdownCancelled(SmcConn a,
                SmPointer b
            )
            {
            }


            public static void SaveYourself(
                SmcConn smcConn,
                SmPointer clientData,
                int saveType,
                bool shutdown,
                int interactStyle,
                bool fast
            )
            {
            }


            public XsmpClient()
            {
                
                 
                
                IntPtr a = IntPtr.Zero, b = IntPtr.Zero;

                string[] i = new[] {""};
                string error = " testerror", prevId = "";

                var p1 = IntPtr.Zero;
                var p2 = IntPtr.Zero;
                var p3 = IntPtr.Zero;

                var errorBuf = new byte[127];

                var x = new SmcCallbacks();
                
                x.shutdown_cancelled = (void*)Marshal.GetFunctionPointerForDelegate(SmcShutdownCancelledProcDel);
 
                fixed (byte* p = errorBuf)
                {
                    var ptr = (IntPtr) p;

                    _smcConn = SmcOpenConnection(IntPtr.Zero,
                        IntPtr.Zero, 1, 0,
                        // SmcSaveYourselfProcMask |
                        // SmcSaveCompleteProcMask |
                        SmcShutdownCancelledProcMask 
                        // SmcDieProcMask
                        ,
                        &x,
                        out var tt1, out var ep2, errorBuf.Length, ptr);
                }

                if (_smcConn == IntPtr.Zero)
                {
                    var errorString = Encoding.ASCII.GetString(errorBuf);
                    Console.WriteLine($"Error! {errorString}");
                }

                var progName = "Avalonia XSMP Client";
                var progNameBytes = Encoding.ASCII.GetBytes(progName);
                fixed (byte* asd = &progNameBytes[0])
                {
                    var sadasd = (IntPtr) asd;

                    var smname = new SmPropValue();
                    smname.Length = progNameBytes.Length;
                    smname.Value = sadasd;

                    var propArray = new[] {smname};
                    var nameBa = Encoding.ASCII.GetBytes("SmProgram");
                    var typeBa = Encoding.ASCII.GetBytes("SmARRAY8");

                    fixed (SmPropValue* propValPtr = &propArray[0])
                    fixed (byte* nameBaPtr = &nameBa[0])
                    fixed (byte* typeBaPtr = &typeBa[0])
                    {
                        var smnameprop = new SmProp();
                        smnameprop.Name = nameBaPtr;
                        smnameprop.Type = typeBaPtr;
                        smnameprop.NumVals = 1;
                        smnameprop.Vals = propValPtr;

                        var propsf = new[] {smnameprop};

                        fixed (SmProp* l1 = &propsf[0])
                        {
                            var propsf0 = new[] {l1};

                            fixed (SmProp** l2 = &propsf0[0])
                            {
                                SmcSetProperties(_smcConn, 1, l2);
                            }
                        }
                    }
                }
            }

            public static void SmcShutdownCancelledProcFunc(SmcConn a, SmPointer b)
            {
                Console.WriteLine("a");
            }

            public static readonly SmcShutdownCancelledProc SmcShutdownCancelledProcDel = SmcShutdownCancelledProcFunc;


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

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate void SmcShutdownCancelledProc(
                SmcConn smcConn,
                SmPointer clientData
            );

            public struct SmProp
            {
                public byte* Name; /* name of property */
                public byte* Type; /* type of property */
                public int NumVals; /* number of values */
                public SmPropValue* Vals; /* the list of values */
            };

            public struct SmPropValue
            {
                public int Length; /* the length of the value */
                public SmPointer Value; /* the value */
            };
            //
            // [StructLayout(LayoutKind.Sequential)]
            // public struct SmcCallbacks
            // {
            //     public delegate* unmanaged[Cdecl] <
            //         SmcConn /* smcConn */,
            //         SmPointer /* clientData */,
            //         int /* saveType */,
            //         bool /* shutdown */,
            //         int /* interactStyle */,
            //         bool /* fast */,
            //         void > save_yourself;
            //
            //     public SmPointer save_yourself_client_data;
            //
            //     public delegate* unmanaged[Cdecl] <
            //         SmcConn /* smcConn */,
            //         SmPointer /* clientData */,
            //         void> die;
            //
            //     public SmPointer die_client_data;
            //
            //     public delegate* unmanaged[Cdecl] < SmcConn /* smcConn */,
            //         SmPointer /* clientData */,
            //         void> save_complete;
            //
            //     public SmPointer save_complete_client_data;
            //
            //     public delegate* unmanaged[Cdecl] < SmcConn /* smcConn */,
            //         SmPointer /* clientData */,
            //         void> shutdown_cancelled;
            //
            //     public SmPointer shutdown_cancelled_client_data;
            // }


            [StructLayout(LayoutKind.Sequential)]
            public struct SmcCallbacks
            {
                public void* save_yourself;

                public SmPointer save_yourself_client_data;

                public void* die;

                public SmPointer die_client_data;

                public void* save_complete;

                public SmPointer save_complete_client_data;

                public void* shutdown_cancelled;

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