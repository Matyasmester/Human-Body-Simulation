using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Body_Simulation_GUI
{
    class Leg : Limb, IBodypart
    {
        public Leg(string name, bool isFunctional)
        {
            this.name = name;
            this.isFunctional = isFunctional;
        }

        public bool HasHair()
        {
            return true;
        }

        public override string Move()
        {
            return "You walk around a little";
            
        }

        public string View()
        {
            return "You see a hairy leg.";
        }
    }
}
