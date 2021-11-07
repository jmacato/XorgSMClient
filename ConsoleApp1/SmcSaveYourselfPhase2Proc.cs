using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SmcSaveYourselfPhase2Proc(IntPtr __0, IntPtr __1);
}