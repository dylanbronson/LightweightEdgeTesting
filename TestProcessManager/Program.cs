using System;
using System.Diagnostics;

namespace TestProcessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running file found at ./testFile");
            Exec("chmod 644 ./testFile");
        }

        public static void Exec(string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\""
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}
