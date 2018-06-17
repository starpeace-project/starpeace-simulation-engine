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

        public List<Town> Towns { get; set; }

        public void AddTown(Town town)
        {
            Towns.Add(town);
        }
    }
}
