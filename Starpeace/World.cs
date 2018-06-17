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
            foreach (Town town in Towns)
            {
                Population += town.CalculatePopulation();
            }
        }

        public void AddTown(Town town)
        {
            Towns.Add(town);
        }
    }
}
