using System;
namespace Starpeace
{
    public class Town
    {
        private string _town_name;

        public string Name {
            get {
                return this._town_name;
            }
            set {
                this._town_name = value;
            }
        }

    }
}
