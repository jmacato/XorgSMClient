using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ConsoleApp1.SMLib
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SmsNewClientProc(IntPtr __0, IntPtr __1, ulong* __2, IntPtr __3, sbyte** __4);
}