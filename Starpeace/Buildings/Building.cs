using System;
using Starpeace;
using System.Collections.Generic;
namespace Starpeace.Buildings
{
    public class Building
    {
        public Building()
        {
        }

        public string Name { get; set; }
        public Location location = new Location();
    }
}
