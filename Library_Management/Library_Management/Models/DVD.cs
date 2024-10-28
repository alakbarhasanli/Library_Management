using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class DVD:LibraryItem
    {
        public DVD(string title, DateTime? publicationyear) : base(title, publicationyear)
        {
        }

        public override void DisplayInfo()
        {
             Console.WriteLine($" Title:{Title} Publication Year:{PublicationYear}  ");
        }
    }
}
