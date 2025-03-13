using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Library
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }

    }
}
