using System;
using Starpeace.Rates;
namespace Starpeace
{
    public class Town
    {
        public string Name { get; set; }
        public Location location = new Location();

        public int Population { get; set; }

        public BirthRates birthRates = new BirthRates();
        public DeathRates deathRates = new DeathRates();

        public void hi()
        {
            deathRates.IncreaseLowClassDeathRate(3);
        }
    }
}
