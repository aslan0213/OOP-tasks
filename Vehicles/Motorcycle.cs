using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
           Console.WriteLine("Motorcycle's engine started...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Motorcycle's engine stopped.");
        }
    }
}
