using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
    public class Book
    {
        public Book(string book)
        {
            string Book = book;

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Книга");
            Console.ResetColor();
        }

      
    }
  
}
