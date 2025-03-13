using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Library
{
    internal class EBook : Book, IReadable
    {
        public double FileSize { get; set; }
        public void Read()
        {
            Console.WriteLine("Reading an ebook on a device.");
        }
        public EBook(string title, string author, int pageCount, double fileSize)
        : base(title, author, pageCount)
        {
            FileSize = fileSize;
        }
    }
}
