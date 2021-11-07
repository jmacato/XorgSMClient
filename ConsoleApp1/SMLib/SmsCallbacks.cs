using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    public unsafe class SmsCallbacks : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 160)]
        public struct __Internal
        {
            internal RegisterClient.__Internal register_client;
            internal InteractRequest.__Internal interact_request;
            internal InteractDone.__Internal interact_done;
            internal SaveYourselfRequest.__Internal save_yourself_request;
            internal SaveYourselfPhase2Request.__Internal save_yourself_phase2_request;
            internal SaveYourselfDone.__Internal save_yourself_done;
            internal CloseConnection.__Internal close_connection;
            internal SetProperties.__Internal set_properties;
            internal DeleteProperties.__Internal delete_properties;
            internal GetProperties.__Internal get_properties;

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public class RegisterClient : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, RegisterClient> NativeToManagedMap = new ConcurrentDictionary<IntPtr, RegisterClient>();

            protected bool __ownsNativeInstance;

            internal static RegisterClient __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new RegisterClient(native.ToPointer(), skipVTables);
            }

            internal static RegisterClient __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static RegisterClient __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new RegisterClient(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private RegisterClient(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected RegisterClient(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public RegisterClient()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public RegisterClient(RegisterClient __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsRegisterClientProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsRegisterClientProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsRegisterClientProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class InteractRequest : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt0_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, InteractRequest> NativeToManagedMap = new ConcurrentDictionary<IntPtr, InteractRequest>();

            protected bool __ownsNativeInstance;

            internal static InteractRequest __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new InteractRequest(native.ToPointer(), skipVTables);
            }

            internal static InteractRequest __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static InteractRequest __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new InteractRequest(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private InteractRequest(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected InteractRequest(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public InteractRequest()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public InteractRequest(InteractRequest __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsInteractRequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsInteractRequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsInteractRequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class InteractDone : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt1_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, InteractDone> NativeToManagedMap = new ConcurrentDictionary<IntPtr, InteractDone>();

            protected bool __ownsNativeInstance;

            internal static InteractDone __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new InteractDone(native.ToPointer(), skipVTables);
            }

            internal static InteractDone __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static InteractDone __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new InteractDone(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private InteractDone(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected InteractDone(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public InteractDone()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public InteractDone(InteractDone __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsInteractDoneProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsInteractDoneProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsInteractDoneProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class SaveYourselfRequest : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt2_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SaveYourselfRequest> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SaveYourselfRequest>();

            protected bool __ownsNativeInstance;

            internal static SaveYourselfRequest __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SaveYourselfRequest(native.ToPointer(), skipVTables);
            }

            internal static SaveYourselfRequest __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SaveYourselfRequest __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SaveYourselfRequest(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SaveYourselfRequest(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SaveYourselfRequest(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SaveYourselfRequest()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfRequest(SaveYourselfRequest __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsSaveYourselfRequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsSaveYourselfRequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsSaveYourselfRequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class SaveYourselfPhase2Request : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt3_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SaveYourselfPhase2Request> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SaveYourselfPhase2Request>();

            protected bool __ownsNativeInstance;

            internal static SaveYourselfPhase2Request __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SaveYourselfPhase2Request(native.ToPointer(), skipVTables);
            }

            internal static SaveYourselfPhase2Request __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SaveYourselfPhase2Request __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SaveYourselfPhase2Request(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SaveYourselfPhase2Request(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SaveYourselfPhase2Request(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SaveYourselfPhase2Request()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfPhase2Request(SaveYourselfPhase2Request __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsSaveYourselfPhase2RequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsSaveYourselfPhase2RequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsSaveYourselfPhase2RequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class SaveYourselfDone : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt4_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SaveYourselfDone> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SaveYourselfDone>();

            protected bool __ownsNativeInstance;

            internal static SaveYourselfDone __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SaveYourselfDone(native.ToPointer(), skipVTables);
            }

            internal static SaveYourselfDone __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SaveYourselfDone __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SaveYourselfDone(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SaveYourselfDone(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SaveYourselfDone(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SaveYourselfDone()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfDone(SaveYourselfDone __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsSaveYourselfDoneProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsSaveYourselfDoneProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsSaveYourselfDoneProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class CloseConnection : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt5_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, CloseConnection> NativeToManagedMap = new ConcurrentDictionary<IntPtr, CloseConnection>();

            protected bool __ownsNativeInstance;

            internal static CloseConnection __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new CloseConnection(native.ToPointer(), skipVTables);
            }

            internal static CloseConnection __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static CloseConnection __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new CloseConnection(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private CloseConnection(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected CloseConnection(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public CloseConnection()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public CloseConnection(CloseConnection __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsCloseConnectionProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsCloseConnectionProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsCloseConnectionProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class SetProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt6_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SetProperties> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SetProperties>();

            protected bool __ownsNativeInstance;

            internal static SetProperties __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SetProperties(native.ToPointer(), skipVTables);
            }

            internal static SetProperties __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SetProperties __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SetProperties(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SetProperties(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SetProperties(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SetProperties()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SetProperties(SetProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsSetPropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsSetPropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsSetPropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class DeleteProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt7_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, DeleteProperties> NativeToManagedMap = new ConcurrentDictionary<IntPtr, DeleteProperties>();

            protected bool __ownsNativeInstance;

            internal static DeleteProperties __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new DeleteProperties(native.ToPointer(), skipVTables);
            }

            internal static DeleteProperties __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static DeleteProperties __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new DeleteProperties(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private DeleteProperties(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected DeleteProperties(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public DeleteProperties()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public DeleteProperties(DeleteProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsDeletePropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsDeletePropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsDeletePropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public class GetProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmsCallbacksUt8_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, GetProperties> NativeToManagedMap = new ConcurrentDictionary<IntPtr, GetProperties>();

            protected bool __ownsNativeInstance;

            internal static GetProperties __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new GetProperties(native.ToPointer(), skipVTables);
            }

            internal static GetProperties __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static GetProperties __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new GetProperties(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private GetProperties(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected GetProperties(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public GetProperties()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public GetProperties(GetProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            private void DisposePartial(bool disposing)
            {
                throw new NotImplementedException();
            }

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            public SmsGetPropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmsGetPropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmsGetPropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ManagerData
            {
                get
                {
                    return ((__Internal*)__Instance)->manager_data;
                }

                set
                {
                    ((__Internal*)__Instance)->manager_data = value;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, SmsCallbacks> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SmsCallbacks>();

        protected bool __ownsNativeInstance;

        internal static SmsCallbacks __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmsCallbacks(native.ToPointer(), skipVTables);
        }

        internal static SmsCallbacks __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static SmsCallbacks __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmsCallbacks(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmsCallbacks(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmsCallbacks(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public SmsCallbacks()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmsCallbacks(SmsCallbacks __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((__Internal*) __Instance) = *((__Internal*) __0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        private void DisposePartial(bool disposing)
        {
            throw new NotImplementedException();
        }

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public RegisterClient register_client
        {
            get
            {
                return RegisterClient.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->register_client));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->register_client = *(RegisterClient.__Internal*) value.__Instance;
            }
        }

        public InteractRequest interact_request
        {
            get
            {
                return InteractRequest.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->interact_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->interact_request = *(InteractRequest.__Internal*) value.__Instance;
            }
        }

        public InteractDone interact_done
        {
            get
            {
                return InteractDone.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->interact_done));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->interact_done = *(InteractDone.__Internal*) value.__Instance;
            }
        }

        public SaveYourselfRequest save_yourself_request
        {
            get
            {
                return SaveYourselfRequest.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_request = *(SaveYourselfRequest.__Internal*) value.__Instance;
            }
        }

        public SaveYourselfPhase2Request save_yourself_phase2_request
        {
            get
            {
                return SaveYourselfPhase2Request.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_phase2_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_phase2_request = *(SaveYourselfPhase2Request.__Internal*) value.__Instance;
            }
        }

        public SaveYourselfDone save_yourself_done
        {
            get
            {
                return SaveYourselfDone.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_done));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_done = *(SaveYourselfDone.__Internal*) value.__Instance;
            }
        }

        public CloseConnection close_connection
        {
            get
            {
                return CloseConnection.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->close_connection));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->close_connection = *(CloseConnection.__Internal*) value.__Instance;
            }
        }

        public SetProperties set_properties
        {
            get
            {
                return SetProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->set_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->set_properties = *(SetProperties.__Internal*) value.__Instance;
            }
        }

        public DeleteProperties delete_properties
        {
            get
            {
                return DeleteProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->delete_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->delete_properties = *(DeleteProperties.__Internal*) value.__Instance;
            }
        }

        public GetProperties get_properties
        {
            get
            {
                return GetProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->get_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->get_properties = *(GetProperties.__Internal*) value.__Instance;
            }
        }
    }
}