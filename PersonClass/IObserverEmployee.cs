using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    interface IObserverEmployee
    {
        void Update(int NumberOfDays, Employee SubstituteManager);
    }
}
