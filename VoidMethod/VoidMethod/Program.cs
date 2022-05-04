using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MyClass instance = new MyClass();
            // multiply 10 by 2 and display 2
            instance.Method(10, 2);
            // multiply 9 by 2 and display 5
            instance.Method(b: 5, a: 9);

            // keep console open
            Console.Read();
        }
    }
}
