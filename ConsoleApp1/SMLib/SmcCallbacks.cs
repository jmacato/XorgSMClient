using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    public unsafe class SmcCallbacks : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 64)]
        public struct __Internal
        {
            internal SaveYourself.__Internal save_yourself;
            internal Die.__Internal die;
            internal SaveComplete.__Internal save_complete;
            internal ShutdownCancelled.__Internal shutdown_cancelled;

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmcCallbacksC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public class SaveYourself : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmcCallbacksUt_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SaveYourself> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SaveYourself>();

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
                    return managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveYourself(SaveYourself __0)
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

            public SmcSaveYourselfProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmcSaveYourselfProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmcSaveYourselfProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->client_data = value;
                }
            }
        }

        public class Die : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmcCallbacksUt0_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, Die> NativeToManagedMap = new ConcurrentDictionary<IntPtr, Die>();

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
                    return managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public Die(Die __0)
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

            public SmcDieProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmcDieProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmcDieProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->client_data = value;
                }
            }
        }

        public class SaveComplete : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmcCallbacksUt1_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, SaveComplete> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SaveComplete>();

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
                    return managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public SaveComplete(SaveComplete __0)
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

            public SmcSaveCompleteProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmcSaveCompleteProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmcSaveCompleteProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->client_data = value;
                }
            }
        }

        public class ShutdownCancelled : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 16)]
            public struct __Internal
            {
                internal IntPtr callback;
                internal IntPtr client_data;

                [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN12SmcCallbacksUt2_C2ERKS0_", CallingConvention = CallingConvention.Cdecl)]
                internal static extern void cctor(IntPtr __instance, IntPtr __0);
            }

            public IntPtr __Instance { get; protected set; }

            internal static readonly ConcurrentDictionary<IntPtr, ShutdownCancelled> NativeToManagedMap = new ConcurrentDictionary<IntPtr, ShutdownCancelled>();

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
                    return managed;
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
                __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
                __ownsNativeInstance = true;
                NativeToManagedMap[__Instance] = this;
            }

            public ShutdownCancelled(ShutdownCancelled __0)
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

            public SmcShutdownCancelledProc Callback
            {
                get
                {
                    var __ptr0 = ((__Internal*)__Instance)->callback;
                    return __ptr0 == IntPtr.Zero? null : (SmcShutdownCancelledProc) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(SmcShutdownCancelledProc));
                }

                set
                {
                    ((__Internal*)__Instance)->callback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
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
                    ((__Internal*)__Instance)->client_data = value;
                }
            }
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, SmcCallbacks> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SmcCallbacks>();

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
                return managed;
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
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmcCallbacks(SmcCallbacks __0)
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

        public SaveYourself save_yourself
        {
            get
            {
                return SaveYourself.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_yourself));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_yourself = *(SaveYourself.__Internal*) value.__Instance;
            }
        }

        public Die die
        {
            get
            {
                return Die.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->die));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->die = *(Die.__Internal*) value.__Instance;
            }
        }

        public SaveComplete save_complete
        {
            get
            {
                return SaveComplete.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->save_complete));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->save_complete = *(SaveComplete.__Internal*) value.__Instance;
            }
        }

        public ShutdownCancelled shutdown_cancelled
        {
            get
            {
                return ShutdownCancelled.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->shutdown_cancelled));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->shutdown_cancelled = *(ShutdownCancelled.__Internal*) value.__Instance;
            }
        }
    }
}