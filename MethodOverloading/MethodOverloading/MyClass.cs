using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class MyClass
    {
        // create a method for MyClass
        public static int Method1(int integer)
        {
            return integer + 2;
        }

        // overload the method to accept decimals and
        // strings, performing different operations on each
        public static int Method1(decimal dec)
        {
            return Convert.ToInt32(dec * 2);
        }
        public static int Method1(string str)
        {
            return Convert.ToInt32(Convert.ToInt32(str) * 99);
        }
    }
}
