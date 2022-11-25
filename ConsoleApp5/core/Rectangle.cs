using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
    public class Rectangle
    {
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }
        
        private double _side1;

		public double Side1
        {
			get { return _side1; }
			set { _side1 = value; }
		}

		private double _side2;

		

		public double Side2
		{
			get { return _side2; }
			set { _side2 = value; }
		}

        public double AreaCalculator()
        {
            return _side1 + _side2;
        }

        public double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }
    }
}
