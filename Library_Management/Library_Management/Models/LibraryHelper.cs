using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            return (DateTime.Now.Year - item.PublicationYear?.Year??0);
        }
        public static string ToTitleCase(this LibraryItem item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(item.Title[0]));
            sb.Append(item.Title.Substring(1,item.Title.Length - 1).ToLower());
            return sb.ToString();

            
        }

    }
}
