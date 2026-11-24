using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class Book
    {
        public string title;
        public int pages;


        public override string ToString()
        {
            return $"Title: {title}, Pages: {pages}";
        }

    }
}
