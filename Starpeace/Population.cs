using System;
using Starpeace.Rates;
using Starpeace.Types;

namespace Starpeace
{
    public class Population
    {
        BirthRates      birthRates      = new BirthRates();
        DeathRates      deathRates      = new DeathRates();
        EmigrationRates emigrationRates = new EmigrationRates();
        PopulationTypes populationTypes = new PopulationTypes();

        public Population()
        {
            
        }

        public void Calculate() 
        {
            Console.WriteLine(populationTypes.HighClass.WorkForceName);
        }


    }
}
