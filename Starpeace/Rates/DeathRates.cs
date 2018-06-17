using System;
namespace Starpeace.Rates
{
    public class DeathRates
    {
        public DeathRates()
        {
            LowClass = 0.008;
            MiddleClass = 0.008;
            HighClass = 0.008;

            Increment = 0.0001;
        }
        public double LowClass { get; set; }
        public double MiddleClass { get; set; }
        public double HighClass { get; set; }

        public double Increment;

        public void IncreaseLowClassDeathRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                LowClass += Increment;
            }
        }

        public void DecreaseLowClassDeathRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                LowClass -= Increment;
            }
        }

        public void IncreaseMiddleClassDeathRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                MiddleClass += Increment;
            }
        }

        public void DecreaseMiddleClassDeathRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                MiddleClass -= Increment;
            }
        }

        public void IncreaseHighClassDeathRate(int increments)
        {
            for (int increment = 0; increment < increments; increment++)
            {
                HighClass += Increment;
            }
        }

        public void DecreaseHighClassDeathRate(int decrements)
        {
            for (int decrement = 0; decrement < decrements; decrement++)
            {
                HighClass -= Increment;
            }
        }

        public double GetLowClassDeaths(double population)
        {
            return Math.Round((LowClass * population) / 365);
        }

        public double GetMiddleClassDeaths(double population)
        {
            return Math.Round((MiddleClass * population) / 365);
        }

        public double GetHighClassDeaths(double population)
        {
            return Math.Round((HighClass * population) / 365);
        }

        public Population CalculateDeaths(Population population)
        {
            population.LowClass.Population -= GetLowClassDeaths(population.LowClass.Population);
            population.MiddleClass.Population -= GetMiddleClassDeaths(population.MiddleClass.Population);
            population.HighClass.Population -= GetHighClassDeaths(population.HighClass.Population);

            return population;
        }
    }
}
