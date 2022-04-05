using System;


namespace FactoryEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tireChoice = int.Parse(Console.ReadLine());
            IVehicle vehicle = VehicleFactory.Getvehicle(tireChoice);
            vehicle.Drive();
        }
    }
}
