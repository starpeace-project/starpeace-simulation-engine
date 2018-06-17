namespace Starpeace.Rates
{
    public class BirthRates
    {
        public BirthRates() {
            LowClass =    0.02;
            MiddleClass = 0.02;
            HighClass =   0.02;
        }
        public double LowClass    { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass   { get; set; }
    }
}
