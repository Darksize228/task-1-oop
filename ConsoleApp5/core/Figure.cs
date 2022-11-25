using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
    internal class Figure
    {
        public Figure(Point x, Point y, Point z)
        {
           

        }

        public Figure(Point x, Point y, Point z, Point x2)
        {
          

        }

        public Figure(Point x, Point y, Point z, Point x2, Point y2)
        {


        }

        public double LengthSide(Point A, Point B) => (A.y + A.x) + (B.y + B.x);

        public void PerimeterCalculator(Point A, Point B)
        {
            Console.WriteLine($"{(A.y + A.x + B.y + B.x) * 2}");
        }
        

    }
}
