using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal interface ILibrarianService
    {
        public Librarian GetLibrarianById(int  id);

        public Librarian[] GetAllLibrarian();

        void CretaeLibrarian(Librarian librarian);

        void DeleteLibrarian(Librarian librarian, bool IsSoftDelete);
    }
}
