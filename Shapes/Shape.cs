using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape : IShape
    {
        public string Colour { get { return "blue"; } set {}}

        public override string ToString()
        {
            return Colour;
        }

        public abstract double GetArea();
    }
}
