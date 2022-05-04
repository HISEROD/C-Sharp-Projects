using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class MyClass
    {
        // distance function for one or two dimensions
        public int Method1(int a, int b = 0)
        {
            return Convert.ToInt32(Math.Sqrt(a * a + b * b));
        }
    }
}
