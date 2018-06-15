using System;
using System.Timers;

namespace Starpeace
{
    class Program
    {
        static readonly Kernel _kernel = new Kernel();

        static void Main(string[] args)
        {
            Console.WriteLine("Engine starting...");

            Timer aTimer = new Timer();
            aTimer.Elapsed += Program.OnTimedEvent;
            aTimer.Interval = 1000; // Milliseconds 1000 = 1 second
            aTimer.Enabled = true;

            do
            {
                //Exit if escape key pressed
                if (Console.ReadKey(true).Key == ConsoleKey.Escape) { Environment.Exit(0); }
            } while (true);
        }

        static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            _kernel.Update();
        }
    }
}
