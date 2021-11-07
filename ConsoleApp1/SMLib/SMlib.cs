using System;
using System.Runtime.InteropServices;
using System.Security;
using CppSharp.Runtime;

namespace SMLib
{
    public unsafe class SMlib
    {
        public struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcOpenConnection", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmcOpenConnection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] string networkId, IntPtr _1, int _2, int _3, ulong _4, IntPtr _5, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] out string _6, 
                [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] out string clientIdRet, int _8, sbyte* _9);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcCloseConnection", CallingConvention = CallingConvention.Cdecl)]
            internal static extern SmcCloseStatus SmcCloseConnection(IntPtr _0, int _1, sbyte** _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcModifyCallbacks", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcModifyCallbacks(IntPtr _0, ulong _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcSetProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcSetProperties(IntPtr _0, int _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcDeleteProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcDeleteProperties(IntPtr _0, int _1, sbyte** _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcGetProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcGetProperties(IntPtr _0, IntPtr _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcInteractRequest", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcInteractRequest(IntPtr _0, int _1, IntPtr _2, IntPtr _3);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcInteractDone", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcInteractDone(IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcRequestSaveYourself", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcRequestSaveYourself(IntPtr _0, int _1, int _2, int _3, int _4, int _5);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcRequestSaveYourselfPhase2", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcRequestSaveYourselfPhase2(IntPtr _0, IntPtr _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcSaveYourselfDone", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmcSaveYourselfDone(IntPtr _0, int _1);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcProtocolVersion(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmcProtocolRevision(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcVendor", CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))]
            internal static extern string SmcVendor(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcRelease", CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))]

            internal static extern string SmcRelease(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcClientID", CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))]

            internal static extern string SmcClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsInitialize", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsInitialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] string _0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaller))] string _1, IntPtr _2, IntPtr _3, IntPtr _4, int _5, sbyte* _6);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsClientHostName", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsClientHostName(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsGenerateClientID", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsGenerateClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsRegisterClientReply", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsRegisterClientReply(IntPtr _0, sbyte* _1);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsSaveYourself", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveYourself(IntPtr _0, int _1, int _2, int _3, int _4);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsSaveYourselfPhase2", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveYourselfPhase2(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsInteract", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsInteract(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsDie", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsDie(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsSaveComplete", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsSaveComplete(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsShutdownCancelled", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsShutdownCancelled(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsReturnProperties", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsReturnProperties(IntPtr _0, int _1, IntPtr _2);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsCleanUp", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmsCleanUp(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsProtocolVersion", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsProtocolVersion(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsProtocolRevision", CallingConvention = CallingConvention.Cdecl)]
            internal static extern int SmsProtocolRevision(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsClientID", CallingConvention = CallingConvention.Cdecl)]
            internal static extern sbyte* SmsClientID(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmcSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmcSetErrorHandler(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmsSetErrorHandler", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr SmsSetErrorHandler(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmFreeProperty", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmFreeProperty(IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "SmFreeReasons", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void SmFreeReasons(int _0, sbyte** _1);
        }

        public static SmcConn SmcOpenConnection(string _0, IntPtr _1, int _2, int _3, ulong _4, SmcCallbacks _5, out string _6, out string _7, int _8, sbyte* _9)
        {
            var __arg5 = _5 is null ? IntPtr.Zero : _5.__Instance;
            var __ret = __Internal.SmcOpenConnection(_0, _1, _2, _3, _4, __arg5, out var _6a, out var _7a, _8, _9);
            var __result0 = SmcConn.__GetOrCreateInstance(__ret);

            _6 = _6a;
            _7 = _7a;
            return __result0;
        }

        public static SmcCloseStatus SmcCloseConnection(SmcConn _0, int _1, sbyte** _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcCloseConnection(__arg0, _1, _2);
            return __ret;
        }

        public static void SmcModifyCallbacks(SmcConn _0, ulong _1, SmcCallbacks _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            __Internal.SmcModifyCallbacks(__arg0, _1, __arg2);
        }

        public static void SmcSetProperties(SmcConn _0, int _1, SmProp _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var ____arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            var __arg2 = new IntPtr(&____arg2);
            __Internal.SmcSetProperties(__arg0, _1, __arg2);
        }

        public static void SmcDeleteProperties(SmcConn _0, int _1, sbyte** _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcDeleteProperties(__arg0, _1, _2);
        }

        public static int SmcGetProperties(SmcConn _0, SmcPropReplyProc _1, IntPtr _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg1 = _1 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_1);
            var __ret = __Internal.SmcGetProperties(__arg0, __arg1, _2);
            return __ret;
        }

        public static int SmcInteractRequest(SmcConn _0, int _1, SmcInteractProc _2, IntPtr _3)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg2 = _2 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_2);
            var __ret = __Internal.SmcInteractRequest(__arg0, _1, __arg2, _3);
            return __ret;
        }

        public static void SmcInteractDone(SmcConn _0, int _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcInteractDone(__arg0, _1);
        }

        public static void SmcRequestSaveYourself(SmcConn _0, int _1, int _2, int _3, int _4, int _5)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcRequestSaveYourself(__arg0, _1, _2, _3, _4, _5);
        }

        public static int SmcRequestSaveYourselfPhase2(SmcConn _0, SmcSaveYourselfPhase2Proc _1, IntPtr _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __arg1 = _1 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_1);
            var __ret = __Internal.SmcRequestSaveYourselfPhase2(__arg0, __arg1, _2);
            return __ret;
        }

        public static void SmcSaveYourselfDone(SmcConn _0, int _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmcSaveYourselfDone(__arg0, _1);
        }

        public static int SmcProtocolVersion(SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcProtocolVersion(__arg0);
            return __ret;
        }

        public static int SmcProtocolRevision(SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcProtocolRevision(__arg0);
            return __ret;
        }

        public static string SmcVendor(SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcVendor(__arg0);
             return __ret;
        }

        public static string SmcRelease(SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcRelease(__arg0);
            return __ret;
        }

        public static string SmcClientID(SmcConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmcClientID(__arg0);
            return __ret;
        }
 

        public static sbyte* SmsClientHostName(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsClientHostName(__arg0);
            return __ret;
        }

        public static sbyte* SmsGenerateClientID(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsGenerateClientID(__arg0);
            return __ret;
        }

        public static int SmsRegisterClientReply(SmsConn _0, sbyte* _1)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsRegisterClientReply(__arg0, _1);
            return __ret;
        }

        public static void SmsSaveYourself(SmsConn _0, int _1, int _2, int _3, int _4)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveYourself(__arg0, _1, _2, _3, _4);
        }

        public static void SmsSaveYourselfPhase2(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveYourselfPhase2(__arg0);
        }

        public static void SmsInteract(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsInteract(__arg0);
        }

        public static void SmsDie(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsDie(__arg0);
        }

        public static void SmsSaveComplete(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsSaveComplete(__arg0);
        }

        public static void SmsShutdownCancelled(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsShutdownCancelled(__arg0);
        }

        public static void SmsReturnProperties(SmsConn _0, int _1, SmProp _2)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var ____arg2 = _2 is null ? IntPtr.Zero : _2.__Instance;
            var __arg2 = new IntPtr(&____arg2);
            __Internal.SmsReturnProperties(__arg0, _1, __arg2);
        }

        public static void SmsCleanUp(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            __Internal.SmsCleanUp(__arg0);
        }

        public static int SmsProtocolVersion(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsProtocolVersion(__arg0);
            return __ret;
        }

        public static int SmsProtocolRevision(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsProtocolRevision(__arg0);
            return __ret;
        }

        public static sbyte* SmsClientID(SmsConn _0)
        {
            var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
            var __ret = __Internal.SmsClientID(__arg0);
            return __ret;
        }

        public static SmcErrorHandler SmcSetErrorHandler(SmcErrorHandler _0)
        {
            var __arg0 = _0 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_0);
            var __ret = __Internal.SmcSetErrorHandler(__arg0);
            var __ptr0 = __ret;
            return __ptr0 == IntPtr.Zero? null : (SmcErrorHandler) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmcErrorHandler));
        }

        public static SmsErrorHandler SmsSetErrorHandler(SmsErrorHandler _0)
        {
            var __arg0 = _0 == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(_0);
            var __ret = __Internal.SmsSetErrorHandler(__arg0);
            var __ptr0 = __ret;
            return __ptr0 == IntPtr.Zero? null : (SmsErrorHandler) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsErrorHandler));
        }

        public static void SmFreeProperty(SmProp _0)
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