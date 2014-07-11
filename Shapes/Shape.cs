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

        public string DisplayInfo()
        {
            return ToString() + " Area = " + GetArea();
        }

        public abstract double GetArea();
    }
}
