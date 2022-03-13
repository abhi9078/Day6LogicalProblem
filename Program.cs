using System;
using System.Diagnostics;
using System.Threading;

namespace Day6LogicalProblem
{
    internal class Program
    {
      public static void SimulateStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.WriteLine("Time elapsed: {0}",
                stopwatch.Elapsed);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Simulate Stopwatch Program");
            Console.ReadKey();
            Console.WriteLine("Starting Stopwatch Time: ");
            Program.SimulateStopwatch();
        }
    }
}

