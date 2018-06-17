using System;
namespace Starpeace.Rates
{
    public class BirthRates
    {
        public BirthRates() {
            LowClass =    0.02;
            MiddleClass = 0.02;
            HighClass =   0.02;

            Increment = 0.001;
        }
        public double LowClass    { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass   { get; set; }

        public double Increment;

        public void IncreaseLowClassBirthRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                LowClass += Increment;
            }
        }

        public void DecreaseLowClassBirthRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                LowClass -= Increment;
            }
        }

        public void IncreaseMiddleClassBirthRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                MiddleClass += Increment;
            }
        }

        public void DecreaseMiddleClassBirthRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                MiddleClass -= Increment;
            }
        }

        public void IncreaseHighClassBirthRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                HighClass += Increment;
            }
        }

        public void DecreaseHighClassBirthRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                HighClass -= Increment;
            }
        }

        public double GetLowClassBirths(double population)
        {
            return Math.Round((LowClass * population) / 365);
        }

        public double GetMiddleClassBirths(double population)
        {
            return Math.Round((MiddleClass * population) / 365);
        }

        public double GetHighClassBirths(double population)
        {
            return Math.Round((HighClass * population) / 365);
        }

        public Population CalculateBirths(Population population)
        {
            population.LowClass.Population += GetLowClassBirths(population.LowClass.Population);
            population.MiddleClass.Population += GetMiddleClassBirths(population.MiddleClass.Population);
            population.HighClass.Population += GetHighClassBirths(population.HighClass.Population);

            return population;
        }
    }
}
