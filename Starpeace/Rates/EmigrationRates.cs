using System;
namespace Starpeace.Rates
{
    public class EmigrationRates
    {
        public EmigrationRates()
        {
            LowClass = 0.8;
            MiddleClass = 0.38;
            HighClass = 0.08;
        }

        public double LowClass { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass { get; set; }
    }
}
