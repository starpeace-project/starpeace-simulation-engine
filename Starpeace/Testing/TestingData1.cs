using System;
namespace Starpeace.Testing
{
    public class TestingData1
    {
        public TestingData1(World world)
        {
            world = MakeTowns(world);
        }

        private World MakeTowns(World world)
        {
            Town springtown = new Town
            {
                Name = "Springtown",
                Population = 1000
            };
            world.Towns.Add(springtown);

            Town newtown = new Town
            {
                Name = "NewTown",
                Population = 2000
            };
            world.Towns.Add(newtown);

            Town ronstown = new Town
            {
                Name = "Rons Town",
                Population = 35000
            };
            world.Towns.Add(ronstown);

            return world;
        }
    }
}
