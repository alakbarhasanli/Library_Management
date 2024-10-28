using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class LibraryCatalog
    {
        public LibraryItem[] books=new LibraryItem[0];

        public LibraryItem this[int id]
        {
            
            get
            {

                try
                {
                    if (id <0)
                        return this[id];
                }

                catch (Exception)
                {
                    Console.WriteLine("Book is not Found");

                }
                return default;
            }
            set { this[id] = value; }


        }
    }

}


