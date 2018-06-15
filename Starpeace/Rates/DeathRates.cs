namespace Starpeace.Rates
{
    public class DeathRates
    {
        public DeathRates()
        {
            LowClass = 1e-6;
            MiddleClass = 1.5e-6;
            HighClass = 2e-6;
        }
        public double LowClass { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass { get; set; }
    }
}
