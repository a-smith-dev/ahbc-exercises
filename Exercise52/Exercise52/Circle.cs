using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public class Circle : IShape
    {
        private const double PI = 3.1415926535;

        public int Radius { get; set; }

        public double GetArea()
        {
            return PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
