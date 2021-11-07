using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SmcPropReplyProc(IntPtr __0, IntPtr __1, int __2, IntPtr __3);
}