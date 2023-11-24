using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Traingle : Shape
    {
        private double baseLength;
        private double height;

        public Traingle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double Area()
        {
            return 0.5 * baseLength * height;
        }
    }
}
