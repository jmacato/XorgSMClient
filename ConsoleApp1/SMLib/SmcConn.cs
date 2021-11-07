using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace SMLib
{
    public unsafe class SmcConn
    {
        public struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, SmcConn> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SmcConn>();

        protected bool __ownsNativeInstance;

        internal static SmcConn __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmcConn(native.ToPointer(), skipVTables);
        }

        internal static SmcConn __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
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

        internal static SmcConn __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmcConn(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmcConn(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmcConn(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }
}