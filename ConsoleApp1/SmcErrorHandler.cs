using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SmcErrorHandler(IntPtr __0, int __1, int __2, ulong __3, int __4, int __5, IntPtr __6);
}