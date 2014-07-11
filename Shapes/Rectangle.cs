using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double area;

        public double Area
        {
            get { return Length*Width; }
            set { area = value; }
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string colour, double length, double width)
        {
            this.Colour = colour;
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return Colour + " " + Length + " " + Width;
        }
    }
}
