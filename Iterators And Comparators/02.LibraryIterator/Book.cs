﻿using System.Collections.Generic;
using System.Linq;

namespace _02.LibraryIterator
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }
    }
}
