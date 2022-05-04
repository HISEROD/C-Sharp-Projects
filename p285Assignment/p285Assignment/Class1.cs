using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p285Assignment
{
    class Class1
    {
        // void method that displays the input / 2
        public void Method(int a)
        {
            Console.WriteLine(a / 2);
        }
        // method with output parameters
        public void Method2(out int a, out int b)
        {
            a = 19;
            b = 22;
        }
        // overloaded method
        public void Method2(out double a, out double b)
        {
            a = 6.28;
            b = 3.14;
        }
    }
}
