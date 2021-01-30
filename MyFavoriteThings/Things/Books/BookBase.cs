using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Books
{
    class BookBase
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        
        public void ListInfo()
        {
            Console.WriteLine($"One of my favorite books is {Name} by {Author}, it is a {Genre} book.");
        }
    }
}
