﻿using System;
using System.Diagnostics;

namespace TestProcessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running file found at ./testFile");
            using var process = Process.Start(new ProcessStartInfo
            {
                FileName = "./testFile",
                ArgumentList = { "hello world" }
            });
            process.WaitForExit();
        }
    }
}
