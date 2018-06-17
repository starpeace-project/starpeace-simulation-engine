namespace Starpeace.Testing
{
    public class TestingData1
    {
        public World MakeTowns(World world)
        {
            Town springtown = new Town
            {
                Name = "Springtown"
            };
            springtown.population.LowClass.Population = 100000;
            springtown.population.MiddleClass.Population = 20000;
            springtown.population.HighClass.Population = 2000;
            world.Towns.Add(springtown);

            Town newtown = new Town
            {
                Name = "NewTown"
            };
            newtown.population.LowClass.Population = 65000;
            newtown.population.MiddleClass.Population = 13000;
            newtown.population.HighClass.Population = 1350;
            world.Towns.Add(newtown);

            Town ronstown = new Town
            {
                Name = "Rons Town"
            };
            ronstown.population.LowClass.Population = 40000;
            ronstown.population.MiddleClass.Population = 10000;
            ronstown.population.HighClass.Population = 650;
            world.Towns.Add(ronstown); 

            return world;
        }
    }
}
