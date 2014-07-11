using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesComposite
{
    class ShapeContainer : IShape
    {
        private List<IShape> childShapes;
        public string Colour { get; set; }

        public ShapeContainer()
        {
            childShapes = new List<IShape>();
        }

        //how to override it?
        public double GetArea()
        {
            double result = 0;

            foreach (IShape shape in this.childShapes)
            {
                result += shape.GetArea();
            }

            return result;
        }

        public string DisplayInfo()
        {
            string result = "";

            foreach (IShape shape in this.childShapes)
            {
                result += shape.ToString();
            }

            return result;
        }

        public void Add(IShape newShape)
        {
            this.childShapes.Add(newShape);
        }

        public void AddRange(params IShape[] newShapes)
        {
            this.childShapes.AddRange(newShapes);
        }

        public void Remove(IShape shapeToRemove)
        {
            this.childShapes.Remove(shapeToRemove);
        }
    }
}
