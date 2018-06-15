namespace Starpeace.Rates
{
    public class BirthRates
    {
        public BirthRates() {
            LowClass =    3e-6;
            MiddleClass = 4e-6;
            HighClass =   5e-6;
        }
        public double LowClass    { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass   { get; set; }
    }
}
