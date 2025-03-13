using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
      
		private string Name;

		public string name
		{
			get { return Name; }
			set { Name = (!string.IsNullOrEmpty(value))?value:throw new ArgumentException("Name cannot be empty."); }
		}

		private double HourlyRate;

		public double hourlyRate
		{
			get { return HourlyRate; }
			set { HourlyRate = (value>0)?value:throw new ArgumentException("Rate can not be zero o negative."); }
		}
		private double HoursWorked;

		public double hoursWorked
		{
			get { return HoursWorked; }
			set { HoursWorked = (value>=0)?value:throw new ArgumentException("Number of hours worled can not be negative."); }
		}
        public Employee(string name, double hourlyRate,double hoursWorked)
        {
			this.name = name;
			this.hourlyRate = hourlyRate;
			this.hoursWorked = hoursWorked;
        }
		public decimal CalculateSalary()
		{
			return (decimal)(HourlyRate * HoursWorked);
		} 
    }
}
