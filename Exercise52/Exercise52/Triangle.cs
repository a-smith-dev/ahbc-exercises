using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public class Triangle : IShape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
