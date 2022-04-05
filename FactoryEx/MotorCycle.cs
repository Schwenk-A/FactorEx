using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    public class MotorCycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the motorcycle.");
        }
    }
}
