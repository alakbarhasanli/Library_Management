using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? PublicationYear { get; set; }

        protected LibraryItem(string title,DateTime? publicationyear)
        {
            Title = title;
            PublicationYear = publicationyear;

        }
        public abstract void DisplayInfo();
        
    }
}
