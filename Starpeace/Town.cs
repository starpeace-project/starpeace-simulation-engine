using System;
using Starpeace.Rates;
namespace Starpeace
{
    public class Town
    {
        public string Name { get; set; }
        public Location location = new Location();

        public Population population = new Population();

        public BirthRates birthRates = new BirthRates();
        public DeathRates deathRates = new DeathRates();

        public Town()
        {
        }

        public double CalculatePopulation()
        {
            population = birthRates.CalculateBirths(population);
            population = deathRates.CalculateDeaths(population);

            return population.LowClass.Population + population.MiddleClass.Population + population.HighClass.Population;
        }

    }
}
