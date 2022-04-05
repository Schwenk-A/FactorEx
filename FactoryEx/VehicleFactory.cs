using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    public static class VehicleFactory
    {
///
        public static IVehicle Getvehicle(int tireAmount)
        {

            switch (tireAmount)
            {
                case 2:
                return new MotorCycle();
                case 4:
                    return new Car();
                default:
                    return new Car();

            }
        }
    }
}
