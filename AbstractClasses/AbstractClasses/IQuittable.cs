using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    interface IQuittable
    {
        // require this method in any derived classes
        void Quit();
    }
}
