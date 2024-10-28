
using Library_Management.Models;

namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {




            
            DateTime DVDPublishDate = new DateTime(2011, 5, 22);
            DateTime BookPublishDate = new DateTime(2005, 12, 12);
            Book book = new Book("titanic", BookPublishDate);
           
            
            book.Genre = BookJenre.Fiction;
            Console.WriteLine($"Passing years since book published: {book.CalculateAge()}");
            Console.WriteLine(book.ToTitleCase());
            book.DisplayInfo();
            
            
            Console.WriteLine("--------------");

            DVD dvd = new DVD("harry potter", DVDPublishDate);
            dvd.ToTitleCase();
            dvd.DisplayInfo();
            Console.WriteLine("--------------");






        }
    }
}
