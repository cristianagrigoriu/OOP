using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeContainer1 = new ShapeContainer();
            var shapeContainer2 = new ShapeContainer();
            var shapeContainer3 = new ShapeContainer();

            shapeContainer1.Add(new Rectangle("purple", 20, 9));
            shapeContainer1.Add(new Triangle(2, 2));

            shapeContainer2.Add(new Triangle(6, 10));

            shapeContainer3.AddRange(shapeContainer1, shapeContainer2);

            Console.WriteLine(shapeContainer3.ToString());
            Console.WriteLine("Total Area = {0}", shapeContainer3.GetArea());
            
        }
    }
}
