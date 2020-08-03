using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise42
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int xVal, int yVal)
        {
            _x = xVal;
            _y = yVal;
        }
        
        public void Created()
        {
            Console.Write($"You have created a point object ");
            Coordinates();
        }
        public void Coordinates()
        {
            Console.Write($"({_x}, {_y})");
        }

    }
}
