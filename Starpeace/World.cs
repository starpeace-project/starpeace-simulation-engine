using System;
using System.Collections.Generic;
using Starpeace;
namespace Starpeace
{
    public class World
    {
        public World()
        {
        }

        public string Name { get; set; }
        public string Area { get; set; }

        public MapSize mapSize = new MapSize();

        public List<Town> Towns = new List<Town>();

        public double Population { get; set; }

        public void CalculatePopulation()
        {
            Population = 0;
            foreach (Town town in Towns)
            {
                Console.WriteLine("Calculating Population For: " + town.Name);
                double newpop = town.CalculatePopulation();
                Console.WriteLine(town.Name + " new population is " + newpop);
                Population += newpop;
            }
        }

        public void AddTown(Town town)
        {
            Towns.Add(town);
        }
    }
}
