using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class TemperatureConverter
    {
		private double celcius;
		public double Celcius
		{
			get { return celcius; }
			set { celcius = value; Fahrenheit = (Celcius * 9 / 5) + 32; }
		}

		private double fahrenheit;
        public double Fahrenheit { get; private set; }
        public TemperatureConverter(double celcius)
        {
          Celcius = celcius;
        }
    }
}
