using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace SMLib
{
    public unsafe class SmsConn
    {
        public struct __Internal
        {
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly ConcurrentDictionary<IntPtr, SmsConn> NativeToManagedMap = new ConcurrentDictionary<IntPtr, SmsConn>();

        protected bool __ownsNativeInstance;

        internal static SmsConn __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmsConn(native.ToPointer(), skipVTables);
        }

        internal static SmsConn __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
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

        internal static SmsConn __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmsConn(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmsConn(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmsConn(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }
    }
}