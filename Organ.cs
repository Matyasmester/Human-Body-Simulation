using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Body_Simulation_GUI
{
    public class Organ
    {
        public string name;

        protected bool isFunctional;
        protected int quality = 10;

        public bool isOrganFunctional()
        {
            return this.isFunctional;
        }

        public virtual string setOrganFailure()
        {
            this.isFunctional = false;
            return "One of your organs has ceased to work. You are dead.";
        }

        public int getQuality()
        {
            return this.quality;
        }
    }
}
