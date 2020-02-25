using System;
using System.Diagnostics;

namespace TestProcessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running file found at /usr/hackathon/testFile");
            Exec();
        }

        public static void Exec()
        {
            using var process = Process.Start(
            new ProcessStartInfo
            {
                FileName = "/usr/hackathon/testFile",
            });
            process.WaitForExit();
        }
    }
}
