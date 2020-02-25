using System;
using System.Diagnostics;

namespace TestProcessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running file found at ./testFile");
            ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "./testFile"};
            Process proc = new Process() { StartInfo = startInfo, };
            proc.Start();
        }
    }
}
