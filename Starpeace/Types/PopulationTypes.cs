using System;
namespace Starpeace.Types
{
    public class PopulationTypes
    {
        public PopulationClass LowClass = new PopulationClass();
        public PopulationClass MiddleClass = new PopulationClass();
        public PopulationClass HighClass = new PopulationClass();

        public PopulationTypes()
        {
            LowClass.Name               = "low_class";
            LowClass.DisplayName        = "Low Class";
            LowClass.WorkForceName      = "Workers";

            MiddleClass.Name            = "middle_class";
            MiddleClass.DisplayName     = "Middle Class";
            MiddleClass.WorkForceName   = "Professionals";

            HighClass.Name              = "high_class";
            HighClass.DisplayName       = "High Class";
            HighClass.WorkForceName     = "Executives";
        }
    }

}
