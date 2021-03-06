﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class ListInfo
    {
        public void DisplayInformation(List<IShape> shapes)
        {
            shapes.ForEach(x => Console.WriteLine(x.GetType().ToString() + " " + x.DisplayInfo()));
        }

        public void DisplayInfoGeneral(List<IObject> objects)
        {
            objects.ForEach(x => Console.WriteLine(x.GetType().ToString() + " " + x.DisplayInfo()));
        }

        public void DisplayInfoGeneric<T>(List<T> objectsList) where T : IObject
        {
            objectsList.ForEach(x => Console.WriteLine(x.GetType().ToString() + " " + x.DisplayInfo()));
        }
    }
}
