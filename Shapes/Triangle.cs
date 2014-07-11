using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double _base, double _height)
        {
            this.Base = _base;
            this.Height = _height;
        }

        public override double GetArea()
        {
            return 0.5*Base*Height;
        }

        public override string ToString()
        {
            return Colour + " " + Base + " " + Height;
        }
    }
}
