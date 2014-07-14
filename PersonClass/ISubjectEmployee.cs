using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    interface ISubjectEmployee
    {
        void Attach();
        void Detach();
        void Notify(int NumberOfDays, Employee SubstituteManager);
    }
}
