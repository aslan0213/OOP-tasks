using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Library
{
    internal class PrintedBook : Book, IReadable
    {
        public void Read()
        {
            Console.WriteLine("Reading a physical book.");
        }
        public PrintedBook(string title, string author, int pageCount)
       : base(title, author, pageCount) { }
        
        
    }
}
