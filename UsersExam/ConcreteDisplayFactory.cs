using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ConcreteDisplayFactory : IAbstractDisplayInfo
    {
        private enum DisplayModes
        {
            File = 1,
            Console
        };

        public IDisplayInfo CreateDisplay(int option)
        {
            switch (option)
            {
                case (int)DisplayModes.File :
                    return new DisplayToFile();
                case (int)DisplayModes.Console:
                    return new DisplayToConsole();
                default:
                    return null;
            }
        }
    }
}
