using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SmsDeletePropertiesProc(IntPtr __0, IntPtr __1, int __2, sbyte** __3);
}