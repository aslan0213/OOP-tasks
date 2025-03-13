using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car's engine started...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car's engine stopped.");
        }
    }
}
