using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class MyClass
    {
        // create method which returns no value
        public void Method(int a, int b)
        {
            a = 2 * a;
            Console.WriteLine(b);
        }
    }
}
