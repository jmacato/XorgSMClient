using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SmsSaveYourselfRequestProc(IntPtr __0, IntPtr __1, int __2, int __3, int __4, int __5, int __6);
}