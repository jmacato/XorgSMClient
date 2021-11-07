using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    public unsafe partial class SmcCallbacks : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 64)]
        public partial struct __Internal
        {
            internal global::SMLib.SmcCallbacks.SaveYourself.__Internal save_yourself;
            internal global::SMLib.SmcCallbacks.Die.__Internal die;
            internal global::SMLib.SmcCallbacks.SaveComplete.__Internal save_complete;
            internal global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal shutdown_cancelled;

            [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmcCallbacksC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public unsafe partial class SaveYourself : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmcCallbacksUt_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.SaveYourself> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.SaveYourself>();

            protected bool __ownsNativeInstance;

            internal static SaveYourself __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SaveYourself(native.ToPointer(), skipVTables);
            }

            internal static SaveYourself __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return (SaveYourself)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SaveYourself __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SaveYourself(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SaveYourself(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SaveYourself(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SaveYourself()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.SaveYourself.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourself(global::SMLib.SmcCallbacks.SaveYourself __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.SaveYourself.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmcCallbacks.SaveYourself.__Internal*) __Instance) = *((global::SMLib.SmcCallbacks.SaveYourself.__Internal*) __0.__Instance);
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

            public global::SMLib.SmcSaveYourselfProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmcSaveYourselfProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmcSaveYourselfProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ClientData
            {
                get
                {
                    return ((__Internal*)__Instance)->client_data;
                }

                set
                {
                    ((__Internal*)__Instance)->client_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class Die : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmcCallbacksUt0_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.Die> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.Die>();

            protected bool __ownsNativeInstance;

            internal static Die __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new Die(native.ToPointer(), skipVTables);
            }

            internal static Die __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return (Die)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static Die __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new Die(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private Die(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected Die(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public Die()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.Die.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public Die(global::SMLib.SmcCallbacks.Die __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.Die.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmcCallbacks.Die.__Internal*) __Instance) = *((global::SMLib.SmcCallbacks.Die.__Internal*) __0.__Instance);
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

            public global::SMLib.SmcDieProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmcDieProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmcDieProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ClientData
            {
                get
                {
                    return ((__Internal*)__Instance)->client_data;
                }

                set
                {
                    ((__Internal*)__Instance)->client_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class SaveComplete : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmcCallbacksUt1_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.SaveComplete> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.SaveComplete>();

            protected bool __ownsNativeInstance;

            internal static SaveComplete __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new SaveComplete(native.ToPointer(), skipVTables);
            }

            internal static SaveComplete __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return (SaveComplete)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static SaveComplete __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new SaveComplete(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private SaveComplete(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected SaveComplete(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public SaveComplete()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.SaveComplete.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveComplete(global::SMLib.SmcCallbacks.SaveComplete __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.SaveComplete.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmcCallbacks.SaveComplete.__Internal*) __Instance) = *((global::SMLib.SmcCallbacks.SaveComplete.__Internal*) __0.__Instance);
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

            public global::SMLib.SmcSaveCompleteProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmcSaveCompleteProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmcSaveCompleteProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ClientData
            {
                get
                {
                    return ((__Internal*)__Instance)->client_data;
                }

                set
                {
                    ((__Internal*)__Instance)->client_data = (IntPtr) value;
                }
            }
        }

        public unsafe partial class ShutdownCancelled : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public partial struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN12SmcCallbacksUt2_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.ShutdownCancelled> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks.ShutdownCancelled>();

            protected bool __ownsNativeInstance;

            internal static ShutdownCancelled __CreateInstance(IntPtr native, bool skipVTables = false)
            {
                return new ShutdownCancelled(native.ToPointer(), skipVTables);
            }

            internal static ShutdownCancelled __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == IntPtr.Zero)
                    return null;
                if (NativeToManagedMap.TryGetValue(native, out var managed))
                    return (ShutdownCancelled)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    NativeToManagedMap[native] = result;
                return result;
            }

            internal static ShutdownCancelled __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new ShutdownCancelled(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private ShutdownCancelled(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            protected ShutdownCancelled(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new IntPtr(native);
            }

            public ShutdownCancelled()
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public ShutdownCancelled(global::SMLib.SmcCallbacks.ShutdownCancelled __0)
            {
                __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
                *((global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal*) __Instance) = *((global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal*) __0.__Instance);
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

            public global::SMLib.SmcShutdownCancelledProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (global::SMLib.SmcShutdownCancelledProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::SMLib.SmcShutdownCancelledProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
                }
            }

            public IntPtr ClientData
            {
                get
                {
                    return ((__Internal*)__Instance)->client_data;
                }

                set
                {
                    ((__Internal*)__Instance)->client_data = (IntPtr) value;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcCallbacks>();

        protected bool __ownsNativeInstance;

        internal static SmcCallbacks __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmcCallbacks(native.ToPointer(), skipVTables);
        }

        internal static SmcCallbacks __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (SmcCallbacks)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static SmcCallbacks __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmcCallbacks(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmcCallbacks(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmcCallbacks(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public SmcCallbacks()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmcCallbacks(global::SMLib.SmcCallbacks __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmcCallbacks.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::SMLib.SmcCallbacks.__Internal*) __Instance) = *((global::SMLib.SmcCallbacks.__Internal*) __0.__Instance);
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

        public global::SMLib.SmcCallbacks.SaveYourself save_yourself
        {
            get
            {
                return global::SMLib.SmcCallbacks.SaveYourself.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself = *(global::SMLib.SmcCallbacks.SaveYourself.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmcCallbacks.Die die
        {
            get
            {
                return global::SMLib.SmcCallbacks.Die.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->die));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->die = *(global::SMLib.SmcCallbacks.Die.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmcCallbacks.SaveComplete save_complete
        {
            get
            {
                return global::SMLib.SmcCallbacks.SaveComplete.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_complete));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_complete = *(global::SMLib.SmcCallbacks.SaveComplete.__Internal*) value.__Instance;
            }
        }

        public global::SMLib.SmcCallbacks.ShutdownCancelled shutdown_cancelled
        {
            get
            {
                return global::SMLib.SmcCallbacks.ShutdownCancelled.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->shutdown_cancelled));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->shutdown_cancelled = *(global::SMLib.SmcCallbacks.ShutdownCancelled.__Internal*) value.__Instance;
            }
        }
    }
}