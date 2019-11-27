using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Body_Simulation_GUI
{
    class Arm : Limb
    {
        public Arm(string name, bool isFunctional)
        {
            this.name = name;
            this.isFunctional = isFunctional;
        }

        public override string Move()
        {
            return base.Move();       
        }
    }
}
