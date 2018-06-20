using System;
using System.Collections.Generic;
using System.Timers;
using Starpeace.Data;
using Starpeace.Data.Models;
using Insight.Database;

namespace Starpeace
{
    class Program
    {
        static Kernel kernel = new Kernel();

        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to database...");
            Database db = new Database();
            var users = db.GetUsers();

            foreach (User user in users)
            {
                Console.WriteLine("UserId=" + user.id + " Username=" + user.name + " UserEmail=" + user.email);
            }

            Console.WriteLine("Engine starting...");

            System.Timers.Timer aTimer = new System.Timers.Timer();
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
            Console.WriteLine("Updating....");
            kernel.Update();
        }
    }
}
