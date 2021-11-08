#nullable enable
using System;
using SmProp = System.IntPtr;

namespace XorgSMLibClient
{
    internal static class Program
    {
        private static void Main(string[] _)
        {
            var k = new XsmpClient();
            Console.ReadLine();
            k.Dispose();
        }
    }
}