using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicles
{
    internal class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("----");
        }

        public override void StopEngine()
        {
            Console.WriteLine("----");
        }
    }
}
