using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1.SMLib
{
    public unsafe partial class SmcConn
    {
        public partial struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcConn> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmcConn>();

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
                return (SmcConn)managed;
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