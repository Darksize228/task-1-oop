using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.core
{
    public class Point
    {
        public int x;
        public int y;
        public string z;

        public Point(int x, int y, string z)
        {
            _ = X;
            _ = Y;
            _ = Z;
        }

        private int _x;

        public int X
        {
            get { return _x; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
        }

        private double _z;

        public double Z
        {
            get { return _z; }
        }
    }
}
