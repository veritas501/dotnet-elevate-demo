using System;
using System.Diagnostics;

namespace dotnet_elevate_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Process currentProcess = Process.GetCurrentProcess();
            string pid = currentProcess.Id.ToString();

            Console.WriteLine(string.Format("[{0}]: 1111", pid));

            // run at the very beginning (before args being used)
            args = ElevateHelper.AutoElevate(args);

            Console.WriteLine(string.Format("[{0}]: 2222", pid));
        }
    }
}
