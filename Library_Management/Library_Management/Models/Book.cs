using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class Book : LibraryItem
    {
        public int Id { get; set; }
        public BookJenre Genre { get; set; }
        public Book(string title, DateTime? publicationyear) : base(title, publicationyear)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($" Title:{Title} Publication Year:{PublicationYear} Book Genre:{Genre} ");
        }
        public struct LibraryLocation()
        {
            public int Aisle { get; set; }
            public int Shelf { get; set; }

            public LibraryLocation(int aisle, int shelf) : this()
            {
                Aisle = aisle;
                Shelf = shelf;


            }

        }
    }
}
