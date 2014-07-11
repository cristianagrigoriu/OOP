using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IShape
    {
        string Colour { get; set; }

        double GetArea();

        string ToString();
    }
}
