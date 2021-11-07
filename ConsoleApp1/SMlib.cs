using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    public unsafe partial class SMlib
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcOpenConnection", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmcOpenConnection(sbyte* _0, IntPtr _1, int _2, int _3, ulong _4, IntPtr _5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string _6, sbyte** _7, int _8, sbyte* _9);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcCloseConnection", CallingConvention = CallingConvention.Cdecl)]
            internal static extern global::SMLib.SmcCloseStatus SmcCloseConnection(IntPtr _0, int _1, sbyte** _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcModifyCallbacks", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcModifyCallbacks(IntPtr _0, ulong _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcSetProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcSetProperties(IntPtr _0, int _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcDeleteProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcDeleteProperties(IntPtr _0, int _1, sbyte** _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcGetProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcGetProperties(IntPtr _0, IntPtr _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcInteractRequest", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcInteractRequest(IntPtr _0, int _1, IntPtr _2, IntPtr _3);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcInteractDone", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcInteractDone(IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcRequestSaveYourself", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcRequestSaveYourself(IntPtr _0, int _1, int _2, int _3, int _4, int _5);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcRequestSaveYourselfPhase2", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcRequestSaveYourselfPhase2(IntPtr _0, IntPtr _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcSaveYourselfDone", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcSaveYourselfDone(IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcProtocolVersion(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcProtocolRevision(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcVendor", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmcVendor(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcRelease", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmcRelease(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcClientID", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmcClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsInitialize", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsInitialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string _0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string _1, IntPtr _2, IntPtr _3, IntPtr _4, int _5, sbyte* _6);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsClientHostName", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsClientHostName(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsGenerateClientID", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsGenerateClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsRegisterClientReply", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsRegisterClientReply(IntPtr _0, sbyte* _1);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsSaveYourself", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveYourself(IntPtr _0, int _1, int _2, int _3, int _4);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsSaveYourselfPhase2", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveYourselfPhase2(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsInteract", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsInteract(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsDie", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsDie(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsSaveComplete", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveComplete(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsShutdownCancelled", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsShutdownCancelled(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsReturnProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsReturnProperties(IntPtr _0, int _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsCleanUp", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsCleanUp(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsProtocolVersion(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsProtocolRevision(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsClientID", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmcSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmcSetErrorHandler(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmsSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmsSetErrorHandler(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmFreeProperty", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmFreeProperty(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("SM.so", EntryPoint = "SmFreeReasons", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmFreeReasons(int _0, sbyte** _1);
        }

        public static global::SMLib.SmcConn SmcOpenConnection(sbyte* _0, IntPtr _1, int _2, int _3, ulong _4, global::SMLib.SmcCallbacks _5, string _6, sbyte** _7, int _8, sbyte* _9)
        {
            var __arg5 = _5 is null ? IntPtr.Zero : _5.__Instance;
            var __ret = __Internal.SmcOpenConnection(_0, _1, _2, _3, _4, __arg5, _6, _7, _8, _9);
            var __result0 = global::SMLib.SmcConn.__GetOrCreateInstance(__ret, false);
            return __result0;
        }

        public static global::SMLib.SmcCloseStatus SmcCloseConnection(global::SMLib.SmcConn _0, int _1, sbyte** _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcCloseConnection(__arg0, _1, _2);
            return __ret;
        }

        public static void SmcModifyCallbacks(global::SMLib.SmcConn _0, ulong _1, global::SMLib.SmcCallbacks _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            __Internal.SmcModifyCallbacks(__arg0, _1, __arg2);
        }

        public static void SmcSetProperties(global::SMLib.SmcConn _0, int _1, global::SMLib.SmProp _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var ____arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            var __arg2 = new IntPtr(&____arg2);
            __Internal.SmcSetProperties(__arg0, _1, __arg2);
        }

        public static void SmcDeleteProperties(global::SMLib.SmcConn _0, int _1, sbyte** _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcDeleteProperties(__arg0, _1, _2);
        }

        public static int SmcGetProperties(global::SMLib.SmcConn _0, global::SMLib.SmcPropReplyProc _1, IntPtr _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg1 = _1 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_1);
            var __ret = __Internal.SmcGetProperties(__arg0, __arg1, _2);
            return __ret;
        }

        public static int SmcInteractRequest(global::SMLib.SmcConn _0, int _1, global::SMLib.SmcInteractProc _2, IntPtr _3)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg2 = _2 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_2);
            var __ret = __Internal.SmcInteractRequest(__arg0, _1, __arg2, _3);
            return __ret;
        }

        public static void SmcInteractDone(global::SMLib.SmcConn _0, int _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcInteractDone(__arg0, _1);
        }

        public static void SmcRequestSaveYourself(global::SMLib.SmcConn _0, int _1, int _2, int _3, int _4, int _5)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcRequestSaveYourself(__arg0, _1, _2, _3, _4, _5);
        }

        public static int SmcRequestSaveYourselfPhase2(global::SMLib.SmcConn _0, global::SMLib.SmcSaveYourselfPhase2Proc _1, IntPtr _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg1 = _1 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_1);
            var __ret = __Internal.SmcRequestSaveYourselfPhase2(__arg0, __arg1, _2);
            return __ret;
        }

        public static void SmcSaveYourselfDone(global::SMLib.SmcConn _0, int _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcSaveYourselfDone(__arg0, _1);
        }

        public static int SmcProtocolVersion(global::SMLib.SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcProtocolVersion(__arg0);
            return __ret;
        }

        public static int SmcProtocolRevision(global::SMLib.SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcProtocolRevision(__arg0);
            return __ret;
        }

        public static sbyte* SmcVendor(global::SMLib.SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcVendor(__arg0);
            return __ret;
        }

        public static sbyte* SmcRelease(global::SMLib.SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcRelease(__arg0);
            return __ret;
        }

        public static sbyte* SmcClientID(global::SMLib.SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcClientID(__arg0);
            return __ret;
        }

        public static int SmsInitialize(string _0, string _1, global::SMLib.SmsNewClientProc _2, IntPtr _3, global::IceHostBasedAuthProc _4, int _5, sbyte* _6)
        {
            var __arg2 = _2 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_2);
            var __arg4 = _4 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_4);
            var __ret = __Internal.SmsInitialize(_0, _1, __arg2, _3, __arg4, _5, _6);
            return __ret;
        }

        public static sbyte* SmsClientHostName(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsClientHostName(__arg0);
            return __ret;
        }

        public static sbyte* SmsGenerateClientID(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsGenerateClientID(__arg0);
            return __ret;
        }

        public static int SmsRegisterClientReply(global::SMLib.SmsConn _0, sbyte* _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsRegisterClientReply(__arg0, _1);
            return __ret;
        }

        public static void SmsSaveYourself(global::SMLib.SmsConn _0, int _1, int _2, int _3, int _4)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveYourself(__arg0, _1, _2, _3, _4);
        }

        public static void SmsSaveYourselfPhase2(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveYourselfPhase2(__arg0);
        }

        public static void SmsInteract(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsInteract(__arg0);
        }

        public static void SmsDie(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsDie(__arg0);
        }

        public static void SmsSaveComplete(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveComplete(__arg0);
        }

        public static void SmsShutdownCancelled(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsShutdownCancelled(__arg0);
        }

        public static void SmsReturnProperties(global::SMLib.SmsConn _0, int _1, global::SMLib.SmProp _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var ____arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            var __arg2 = new IntPtr(&____arg2);
            __Internal.SmsReturnProperties(__arg0, _1, __arg2);
        }

        public static void SmsCleanUp(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsCleanUp(__arg0);
        }

        public static int SmsProtocolVersion(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsProtocolVersion(__arg0);
            return __ret;
        }

        public static int SmsProtocolRevision(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsProtocolRevision(__arg0);
            return __ret;
        }

        public static sbyte* SmsClientID(global::SMLib.SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsClientID(__arg0);
            return __ret;
        }

        public static global::SMLib.SmcErrorHandler SmcSetErrorHandler(global::SMLib.SmcErrorHandler _0)
        {
            var __arg0 = _0 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_0);
            var __ret = __Internal.SmcSetErrorHandler(__arg0);
            var __ptr0 = __ret;
            return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmcErrorHandler) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmcErrorHandler));
        }

        public static global::SMLib.SmsErrorHandler SmsSetErrorHandler(global::SMLib.SmsErrorHandler _0)
        {
            var __arg0 = _0 == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_0);
            var __ret = __Internal.SmsSetErrorHandler(__arg0);
            var __ptr0 = __ret;
            return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsErrorHandler) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsErrorHandler));
        }

        public static void SmFreeProperty(global::SMLib.SmProp _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmFreeProperty(__arg0);
        }

        public static void SmFreeReasons(int _0, sbyte** _1)
        {
            __Internal.SmFreeReasons(_0, _1);
        }
    }
}