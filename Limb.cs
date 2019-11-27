using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Body_Simulation_GUI
{
    public class Limb
    {
        public string name;
        protected bool isFunctional;

        public bool getStatus()
        {
            return isFunctional;
        }

        public void setStatus(bool newValue)
        {
            this.isFunctional = newValue;
        }

        public virtual string Move()
        {
            return "One of your limbs is moving";
        }
    }
}
