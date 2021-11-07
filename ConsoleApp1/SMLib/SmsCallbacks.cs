using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    public unsafe partial class SmsCallbacks : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 160)]
        public partial struct __Internal
        {
            internal global::SMLib.SmsCallbacks.RegisterClient.__Internal register_client;
            internal global::SMLib.SmsCallbacks.InteractRequest.__Internal interact_request;
            internal global::SMLib.SmsCallbacks.InteractDone.__Internal interact_done;
            internal global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal save_yourself_request;
            internal global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal save_yourself_phase2_request;
            internal global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal save_yourself_done;
            internal global::SMLib.SmsCallbacks.CloseConnection.__Internal close_connection;
            internal global::SMLib.SmsCallbacks.SetProperties.__Internal set_properties;
            internal global::SMLib.SmsCallbacks.DeleteProperties.__Internal delete_properties;
            internal global::SMLib.SmsCallbacks.GetProperties.__Internal get_properties;

            [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class RegisterClient : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.RegisterClient> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.RegisterClient>();

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
                    return (RegisterClient)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.RegisterClient.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public RegisterClient(global::SMLib.SmsCallbacks.RegisterClient __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.RegisterClient.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.RegisterClient.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.RegisterClient.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsRegisterClientProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsRegisterClientProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsRegisterClientProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class InteractRequest : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt0_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.InteractRequest> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.InteractRequest>();

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
                    return (InteractRequest)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.InteractRequest.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public InteractRequest(global::SMLib.SmsCallbacks.InteractRequest __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.InteractRequest.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.InteractRequest.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.InteractRequest.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsInteractRequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsInteractRequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsInteractRequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class InteractDone : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt1_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.InteractDone> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.InteractDone>();

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
                    return (InteractDone)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.InteractDone.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public InteractDone(global::SMLib.SmsCallbacks.InteractDone __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.InteractDone.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.InteractDone.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.InteractDone.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsInteractDoneProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsInteractDoneProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsInteractDoneProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class SaveYourselfRequest : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt2_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfRequest> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfRequest>();

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
                    return (SaveYourselfRequest)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfRequest(global::SMLib.SmsCallbacks.SaveYourselfRequest __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsSaveYourselfRequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsSaveYourselfRequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsSaveYourselfRequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class SaveYourselfPhase2Request : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt3_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfPhase2Request> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfPhase2Request>();

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
                    return (SaveYourselfPhase2Request)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfPhase2Request(global::SMLib.SmsCallbacks.SaveYourselfPhase2Request __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsSaveYourselfPhase2RequestProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsSaveYourselfPhase2RequestProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsSaveYourselfPhase2RequestProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class SaveYourselfDone : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt4_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfDone> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SaveYourselfDone>();

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
                    return (SaveYourselfDone)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourselfDone(global::SMLib.SmsCallbacks.SaveYourselfDone __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsSaveYourselfDoneProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsSaveYourselfDoneProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsSaveYourselfDoneProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class CloseConnection : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt5_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.CloseConnection> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.CloseConnection>();

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
                    return (CloseConnection)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.CloseConnection.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public CloseConnection(global::SMLib.SmsCallbacks.CloseConnection __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.CloseConnection.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.CloseConnection.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.CloseConnection.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsCloseConnectionProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsCloseConnectionProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsCloseConnectionProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class SetProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt6_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SetProperties> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.SetProperties>();

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
                    return (SetProperties)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SetProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SetProperties(global::SMLib.SmsCallbacks.SetProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.SetProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.SetProperties.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.SetProperties.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsSetPropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsSetPropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsSetPropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class DeleteProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt7_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.DeleteProperties> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.DeleteProperties>();

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
                    return (DeleteProperties)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.DeleteProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public DeleteProperties(global::SMLib.SmsCallbacks.DeleteProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.DeleteProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.DeleteProperties.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.DeleteProperties.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsDeletePropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsDeletePropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsDeletePropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class GetProperties : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr manager_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmsCallbacksUt8_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.GetProperties> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks.GetProperties>();

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
                    return (GetProperties)managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.GetProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public GetProperties(global::SMLib.SmsCallbacks.GetProperties __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.GetProperties.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmsCallbacks.GetProperties.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.GetProperties.__Internal*) __0.__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

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

            public global::SMLib.SmsGetPropertiesProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmsGetPropertiesProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmsGetPropertiesProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->manager_data = (IntPtr) value;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmsCallbacks>();

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
                return (SmsCallbacks)managed;
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
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmsCallbacks(global::SMLib.SmsCallbacks __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmsCallbacks.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::SMLib.SmsCallbacks.__Internal*) __Instance) = *((global::SMLib.SmsCallbacks.__Internal*) __0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

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

        public global::SMLib.SmsCallbacks.RegisterClient register_client
        {
            get
            {
                return global::SMLib.SmsCallbacks.RegisterClient.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->register_client));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->register_client = *(global::SMLib.SmsCallbacks.RegisterClient.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.InteractRequest interact_request
        {
            get
            {
                return global::SMLib.SmsCallbacks.InteractRequest.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->interact_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->interact_request = *(global::SMLib.SmsCallbacks.InteractRequest.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.InteractDone interact_done
        {
            get
            {
                return global::SMLib.SmsCallbacks.InteractDone.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->interact_done));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->interact_done = *(global::SMLib.SmsCallbacks.InteractDone.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.SaveYourselfRequest save_yourself_request
        {
            get
            {
                return global::SMLib.SmsCallbacks.SaveYourselfRequest.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_request = *(global::SMLib.SmsCallbacks.SaveYourselfRequest.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.SaveYourselfPhase2Request save_yourself_phase2_request
        {
            get
            {
                return global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_phase2_request));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_phase2_request = *(global::SMLib.SmsCallbacks.SaveYourselfPhase2Request.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.SaveYourselfDone save_yourself_done
        {
            get
            {
                return global::SMLib.SmsCallbacks.SaveYourselfDone.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself_done));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself_done = *(global::SMLib.SmsCallbacks.SaveYourselfDone.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.CloseConnection close_connection
        {
            get
            {
                return global::SMLib.SmsCallbacks.CloseConnection.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->close_connection));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->close_connection = *(global::SMLib.SmsCallbacks.CloseConnection.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.SetProperties set_properties
        {
            get
            {
                return global::SMLib.SmsCallbacks.SetProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->set_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->set_properties = *(global::SMLib.SmsCallbacks.SetProperties.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.DeleteProperties delete_properties
        {
            get
            {
                return global::SMLib.SmsCallbacks.DeleteProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->delete_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->delete_properties = *(global::SMLib.SmsCallbacks.DeleteProperties.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmsCallbacks.GetProperties get_properties
        {
            get
            {
                return global::SMLib.SmsCallbacks.GetProperties.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->get_properties));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->get_properties = *(global::SMLib.SmsCallbacks.GetProperties.__Internal*) value.__Instance;
            }
        }
    }
}