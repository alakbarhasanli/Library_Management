using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class LibrarianService : ILibrarianService
    {
        private readonly Librarian[] _librarians;
        public void CretaeLibrarian(Librarian librarian)
        {
            Librarian[] createlibrarian=new Librarian[_librarians.Length+1];
            for (int i = 0; i < _librarians.Length; i++)
            {
                createlibrarian[i] = _librarians[i];
            }
            createlibrarian[_librarians.Length] = librarian;


        }

        public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
        {

           
        }

        public Librarian[] GetAllLibrarian()
        {
            return _librarians;
        }

        public Librarian GetLibrarianById(int id)
        {
            return _librarians[id];
            
        }
    }
}
