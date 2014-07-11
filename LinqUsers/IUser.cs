using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace LinqUsers
{
    interface IUser : IObject
    {
        string Username { get; set; }
        string Password { get; set; }

        string ToString();
    }
}
