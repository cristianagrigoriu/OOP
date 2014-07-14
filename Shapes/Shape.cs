using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        public string Colour { get { return "blue"; } set {}}

        public StringBuilder DisplayInfo()
        {
            StringBuilder result = new StringBuilder(ToString());
            result.Append(" Area = ");
            result.Append(GetArea());
            return result;
        }

        public abstract double GetArea();
    }
}
