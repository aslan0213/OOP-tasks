using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Product
    {
        public string Name { get; init; }

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set 
			{
				if (value <0)
					throw new ArgumentException("Price can not be negative");
                price = value;
			}
		}
        private int stock;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock can not be negative.");
                stock = value;
            }
        }
        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

    }
}
