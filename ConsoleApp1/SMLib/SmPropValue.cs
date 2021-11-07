using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    public unsafe class SmPropValue : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public struct __Internal
        {
            internal int length;
            internal IntPtr value;

            [SuppressUnmanagedCodeSecurity, DllImport("libSM.so.6", EntryPoint = "_ZN11SmPropValueC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, SmPropValue> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SmPropValue>();

        protected bool __ownsNativeInstance;

        internal static SmPropValue __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmPropValue(native.ToPointer(), skipVTables);
        }

        internal static SmPropValue __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
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

        internal static SmPropValue __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmPropValue(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmPropValue(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmPropValue(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public SmPropValue()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmPropValue(SmPropValue __0)
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

        public int Length
        {
            get
            {
                return ((__Internal*)__Instance)->length;
            }

            set
            {
                ((__Internal*)__Instance)->length = value;
            }
        }

        public IntPtr Value
        {
            get
            {
                return ((__Internal*)__Instance)->value;
            }

            set
            {
                ((__Internal*)__Instance)->value = value;
            }
        }
    }
}