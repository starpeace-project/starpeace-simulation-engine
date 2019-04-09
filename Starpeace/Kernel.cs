using System;
using Starpeace.Testing;

namespace Starpeace
{
    public class Kernel
    {
        double Counter = 0;
        World world = new World();
        TestingData1 testingData = new TestingData1();

        public Kernel()
        {
            Initialise();
        }

        public void Initialise()
        {
            /**
             * This is where we are going to get our initial settings from the database
             * for us to setup the engine, in this way, on restart of server, it will also
             * pickup where we left off
             */

            world = testingData.MakeTowns(world);
        }

        public bool Update()
        {
            Counter += 1;
            world.CalculatePopulation();
            Console.WriteLine("Population Calculated, World Population is now: " + world.Population);
            return true;
        }
    }
}
