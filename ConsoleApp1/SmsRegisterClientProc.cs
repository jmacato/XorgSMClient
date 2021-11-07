using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SmsRegisterClientProc(IntPtr __0, IntPtr __1, sbyte* __2);
}