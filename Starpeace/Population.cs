using System;
namespace Starpeace
{
    public class Population
    {
        public PopulationClass LowClass = new PopulationClass();
        public PopulationClass MiddleClass = new PopulationClass();
        public PopulationClass HighClass = new PopulationClass();

        public Population()
        {
            LowClass.Name               = "low_class";
            LowClass.DisplayName        = "Low Class";
            LowClass.WorkForceName      = "Workers";
            LowClass.Population = 0;

            MiddleClass.Name            = "middle_class";
            MiddleClass.DisplayName     = "Middle Class";
            MiddleClass.WorkForceName   = "Professionals";
            MiddleClass.Population = 0;

            HighClass.Name              = "high_class";
            HighClass.DisplayName       = "High Class";
            HighClass.WorkForceName     = "Executives";
            HighClass.Population = 0;
        }
    }

}
