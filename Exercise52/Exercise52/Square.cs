using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength * 4;
        }
    }
}
