using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal  class Librarian:Person
    {
        public Librarian(string name) : base(name)
        {
            this.Name = name;
        }

        public DateTime HireDate { get; set; }
    }
}
