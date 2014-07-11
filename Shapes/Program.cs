using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Rectangle("red", 18, 2),
                new Rectangle("green", 9, 0),
                new Triangle(9, 1),
                new Triangle(2, 12),
                new Triangle(1, 9)
            };

            shapes.ForEach(x => Console.WriteLine(x.GetType().ToString() + " " + x.ToString() + " Area = " + x.GetArea()));
        }
    }
}
