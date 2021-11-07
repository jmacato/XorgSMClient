using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    public unsafe partial class SmProp : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public partial struct __Internal
        {
            internal IntPtr name;
            internal IntPtr type;
            internal int num_vals;
            internal IntPtr vals;

            [SuppressUnmanagedCodeSecurity, DllImport("SMLib", EntryPoint = "_ZN6SmPropC2ERKS_", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void cctor(IntPtr __instance, IntPtr __0);
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmProp> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::SMLib.SmProp>();

        protected bool __ownsNativeInstance;

        internal static SmProp __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new SmProp(native.ToPointer(), skipVTables);
        }

        internal static SmProp __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (SmProp)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static SmProp __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SmProp(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private SmProp(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SmProp(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public SmProp()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmProp.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SmProp(global::SMLib.SmProp __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::SMLib.SmProp.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::SMLib.SmProp.__Internal*) __Instance) = *((global::SMLib.SmProp.__Internal*) __0.__Instance);
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

        public sbyte* Name
        {
            get
            {
                return (sbyte*) ((__Internal*)__Instance)->name;
            }

            set
            {
                ((__Internal*)__Instance)->name = (IntPtr) value;
            }
        }

        public sbyte* Type
        {
            get
            {
                return (sbyte*) ((__Internal*)__Instance)->type;
            }

            set
            {
                ((__Internal*)__Instance)->type = (IntPtr) value;
            }
        }

        public int NumVals
        {
            get
            {
                return ((__Internal*)__Instance)->num_vals;
            }

            set
            {
                ((__Internal*)__Instance)->num_vals = value;
            }
        }

        public global::SMLib.SmPropValue Vals
        {
            get
            {
                var __result0 = global::SMLib.SmPropValue.__GetOrCreateInstance(((__Internal*)__Instance)->vals, false);
                return __result0;
            }

            set
            {
                ((__Internal*)__Instance)->vals = value is null ? IntPtr.Zero : value.__Instance;
            }
        }
    }
}