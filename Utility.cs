using System;
using System.Diagnostics;
using System.Threading;

namespace BakeryFreshBread
{
    static class Utility
    {
        // Timer is in TotalMilliseconds to avoid waiting for too long. Change to TotalMinutes for real life
        public static void WaitTimer(int waitTime)
        {
            Stopwatch timer = new();
            Console.Write("Processing ");
            timer.Start();
            while (timer.Elapsed.TotalMilliseconds < waitTime)
            {
                Console.Write("\b ");
                Thread.Sleep(500);
                Console.Write("\b");
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("\b \b\b \b");
            }
            timer.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nProcess Completed");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Beep();
        }

        public static int ValidateNumericInput() // Check if input is int number
        {
            int input;
            String result = Console.ReadLine();
            while (!Int32.TryParse(result, out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(x) Invalid number, try again.");
                Console.ForegroundColor = ConsoleColor.Gray;
                result = Console.ReadLine();
            }
            return input;
        }
    }
}
