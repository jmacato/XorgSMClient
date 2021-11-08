#nullable enable
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace XorgSMLibClient
{
    public unsafe class XsmpClient : IDisposable
    {
        private const ulong SmcSaveYourselfProcMask = 1L << 0;
        private const ulong SmcDieProcMask = 1L << 1;
        private const ulong SmcSaveCompleteProcMask = 1L << 2;
        private const ulong SmcShutdownCancelledProcMask = 1L << 3;

        private static readonly ConcurrentDictionary<IntPtr, XsmpClient> NativeToManagedMapper = new();
        private static readonly SmcSaveYourselfProc StaticSaveYourselfProcDelegate = SmcSaveYourselfHandler;
        private static readonly SmcDieProc StaticDieDelegate = SmcDieHandler;
        private static readonly SmcShutdownCancelledProc StaticShutdownCancelledDelegate = SmcShutdownCancelledHandler;
        private static readonly SmcSaveCompleteProc StaticSaveCompleteDelegate = SmcSaveCompleteHandler;
        private static readonly SmcInteractProc SmcInteractDelegate = StaticInteractHandler;
        private static readonly SmcErrorHandler SmcErrorHandlerDelegate = StaticErrorHandler;
        private static readonly IceWatchProc IceWatchProcDelegate = IceWatchHandler;
        
        private static SmcCallbacks _callbacks = new()
        {
            shutdown_cancelled = Marshal.GetFunctionPointerForDelegate(StaticShutdownCancelledDelegate),
            die = Marshal.GetFunctionPointerForDelegate(StaticDieDelegate),
            save_yourself = Marshal.GetFunctionPointerForDelegate(StaticSaveYourselfProcDelegate),
            save_complete = Marshal.GetFunctionPointerForDelegate(StaticSaveCompleteDelegate)
        };

        private readonly CancellationTokenSource _cancellationTokenSource = new();
        private readonly IntPtr _currentIceConn;
        private readonly IntPtr _currentSmcConn;

        private bool _saveYourselfPhase;

        public XsmpClient()
        {
            if (IceAddConnectionWatch(
                Marshal.GetFunctionPointerForDelegate(IceWatchProcDelegate),
                IntPtr.Zero) == 0)
            {
                Dispose();
                throw new InvalidOperationException("ICE connection watch registration failed");
            }

            var errorBuf = new char[255];
            var smcConn = SmcOpenConnection(null!,
                IntPtr.Zero, 1, 0,
                SmcSaveYourselfProcMask |
                SmcSaveCompleteProcMask |
                SmcShutdownCancelledProcMask |
                SmcDieProcMask,
                ref _callbacks,
                out   _,
                out   _,
                errorBuf.Length,
                errorBuf);

            if (smcConn == IntPtr.Zero) throw new InvalidOperationException(new string(errorBuf));

            if (!NativeToManagedMapper.TryAdd(smcConn, this))
                throw new InvalidOperationException("Was unable to add instance to the native to managed map.");


            var __ = SmcSetErrorHandler(Marshal.GetFunctionPointerForDelegate(SmcErrorHandlerDelegate));

            _currentSmcConn = smcConn;
            _currentIceConn = SmcGetIceConnection(smcConn);

            Task.Run(() =>
            {
                var token = _cancellationTokenSource.Token;
                while (!token.IsCancellationRequested) HandleRequests();
            }, _cancellationTokenSource.Token);
        }

        public void Dispose()
        {
            if (_currentSmcConn != IntPtr.Zero)
            {
                var _ = SmcCloseConnection(_currentSmcConn, 1, new[]
                {
                    $"{nameof(XsmpClient)} was disposed in managed code."
                });
            }
        }

        private static void SmcSaveCompleteHandler(IntPtr smcConn, IntPtr clientData)
        {
            GetInstance(smcConn)?.SaveCompleteHandler();
        }

        private static XsmpClient? GetInstance(IntPtr smcConn)
        {
            return NativeToManagedMapper.TryGetValue(smcConn, out var instance) ? instance : null;
        }

        private static void SmcShutdownCancelledHandler(IntPtr smcConn, IntPtr clientData)
        {
            GetInstance(smcConn)?.ShutdownCancelledHandler();
        }

        private static void SmcDieHandler(IntPtr smcConn, IntPtr clientData)
        {
            GetInstance(smcConn)?.DieHandler();
        }

        private static void SmcSaveYourselfHandler(IntPtr smcConn, IntPtr clientData, int saveType,
            bool shutdown, int interactStyle, bool fast)
        {
            GetInstance(smcConn)?.SaveYourselfHandler(smcConn, clientData, shutdown, fast);
        }

        private static void StaticInteractHandler(IntPtr smcConn, IntPtr clientData)
        {
            GetInstance(smcConn)?.InteractHandler(smcConn);
        }
        
        
        private static void StaticErrorHandler(IntPtr smcConn, bool swap, int offendingMinorOpcode, ulong offendingSequence, int errorClass, int severity, IntPtr values)
        {
            GetInstance(smcConn)?.ErrorHandler(swap, offendingMinorOpcode, offendingSequence, errorClass, severity, values);
        }

        private void ErrorHandler(bool swap, int offendingMinorOpcode, ulong offendingSequence, int errorClass, int severity, IntPtr values)
        {
            
        }

        private void HandleRequests()
        {
            if (IceProcessMessages(_currentIceConn, out _, out _) ==
                IceProcessMessagesStatus.IceProcessMessagesIoError)
            {
                throw new InvalidOperationException("XSMP lost ICE connection");
            }
        }

        private void SaveCompleteHandler()
        {
            _saveYourselfPhase = false;
        }

        private void ShutdownCancelledHandler()
        {
            if (_saveYourselfPhase)
                SmcSaveYourselfDone(_currentSmcConn, true);
            _saveYourselfPhase = false;
        }

        private void DieHandler()
        {
            var _ = SmcCloseConnection(_currentSmcConn, 1, new[]
            {
                "Session manager was terminated."
            });
        }

        private void SaveYourselfHandler(IntPtr smcConn, IntPtr clientData, bool shutdown, bool fast)
        {
            if (_saveYourselfPhase)
                SmcSaveYourselfDone(smcConn, true);
            _saveYourselfPhase = true;

            if (shutdown && !fast)
            {
                var _ = SmcInteractRequest(smcConn, SmDialogValue.SmDialogError,
                    Marshal.GetFunctionPointerForDelegate(SmcInteractDelegate),
                    clientData);
            }
            else
            {
                SmcSaveYourselfDone(smcConn, true);
                _saveYourselfPhase = false;
            }
        }

        private void InteractHandler(IntPtr smcConn)
        {
            var cancelShutdown = true;
            //call the shutdownrequested callback here.
            Console.WriteLine("Cancelling Shutdown...");
            SmcInteractDone(smcConn, cancelShutdown);
            if (!cancelShutdown)
            {
                _saveYourselfPhase = false;
                SmcSaveYourselfDone(smcConn, true);
            }
        }

        private static void IceWatchHandler(IntPtr iceConn, IntPtr clientData, bool opening,
            IntPtr* watchData
        )
        {
            if (!opening) return;
            IceRemoveConnectionWatch(Marshal.GetFunctionPointerForDelegate(IceWatchProcDelegate),
                IntPtr.Zero);
        }

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi)]
        private static extern IntPtr SmcOpenConnection(
            [MarshalAs(UnmanagedType.LPWStr)] string networkId,
            IntPtr content,
            int xsmpMajorRev,
            int xsmpMinorRev,
            ulong mask,
            ref SmcCallbacks callbacks,
            [MarshalAs(UnmanagedType.LPWStr)] [Out]
            out string previousId,
            [MarshalAs(UnmanagedType.LPWStr)] [Out]
            out string clientIdRet,
            int errorLength,
            [Out] char[] errorStringRet);

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern int SmcCloseConnection(
            IntPtr smcConn,
            int count,
            string[] reasonMsgs
        );

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern void SmcSaveYourselfDone(
            IntPtr smcConn,
            bool success
        );

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern int SmcInteractRequest(
            IntPtr smcConn,
            SmDialogValue dialogType,
            IntPtr interactProc,
            IntPtr clientData
        );

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern void SmcInteractDone(
            IntPtr smcConn,
            bool success
        );

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr SmcGetIceConnection(
            IntPtr smcConn
        );

        [DllImport("libSM.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr SmcSetErrorHandler(
            IntPtr handler
        );

        [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern int IceAddConnectionWatch(
            IntPtr watchProc,
            IntPtr clientData
        );

        [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern void IceRemoveConnectionWatch(
            IntPtr watchProc,
            IntPtr clientData
        );

        [DllImport("libICE.so.6", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IceProcessMessagesStatus IceProcessMessages(
            IntPtr iceConn,
            out IntPtr replyWait,
            out bool replyReadyRet
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void IceWatchProc(
            IntPtr iceConn,
            IntPtr clientData,
            bool opening,
            IntPtr* watchData
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcDieProc(
            IntPtr smcConn,
            IntPtr clientData
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcInteractProc(
            IntPtr smcConn,
            IntPtr clientData
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcSaveCompleteProc(
            IntPtr smcConn,
            IntPtr clientData
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcSaveYourselfProc(
            IntPtr smcConn,
            IntPtr clientData,
            int saveType,
            bool shutdown,
            int interactStyle,
            bool fast
        );

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcShutdownCancelledProc(
            IntPtr smcConn,
            IntPtr clientData
        );


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void SmcErrorHandler(
            IntPtr smcConn,
            bool swap,
            int offendingMinorOpcode,
            ulong offendingSequence,
            int errorClass,
            int severity,
            IntPtr values
        );


        private enum IceProcessMessagesStatus
        {
            IceProcessMessagesIoError = 1
        }

        private enum SmDialogValue
        {
            SmDialogError = 0
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SmcCallbacks
        {
            internal IntPtr save_yourself;
            private readonly IntPtr save_yourself_client_data;
            internal IntPtr die;
            private readonly IntPtr die_client_data;
            internal IntPtr save_complete;
            private readonly IntPtr save_complete_client_data;
            internal IntPtr shutdown_cancelled;
            private readonly IntPtr shutdown_cancelled_client_data;
        }
    }
}