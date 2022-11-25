using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
   public class Author
    { 
        public Author(string author)
        {
            string Author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор");
            Console.ResetColor();
        }
    }
}
