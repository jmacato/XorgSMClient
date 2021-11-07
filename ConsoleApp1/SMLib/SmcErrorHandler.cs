using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SmcErrorHandler(IntPtr __0, int __1, int __2, ulong __3, int __4, int __5, IntPtr __6);
}