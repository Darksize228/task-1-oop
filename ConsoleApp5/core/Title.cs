using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp5.core
{
  public  class Title
    {
       public Title(string title)
        {
            string Title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название");
            Console.ResetColor();
        }
    }
}




