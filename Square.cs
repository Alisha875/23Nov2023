using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
