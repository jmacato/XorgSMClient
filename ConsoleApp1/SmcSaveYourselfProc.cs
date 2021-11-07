using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SmcSaveYourselfProc(IntPtr __0, IntPtr __1, int __2, int __3, int __4, int __5);
}