using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Body_Simulation_GUI
{
    public interface IBodypart
    {
        string View();
        bool HasHair();
    }
}
