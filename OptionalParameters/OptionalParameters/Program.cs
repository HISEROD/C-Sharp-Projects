using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class
            MyClass instance = new MyClass();
            // get input from user
            Console.WriteLine("Please enter either one or two numbers one at a time:");
            int a = Convert.ToInt32(Console.ReadLine());
            // second input stored as a string to prevent exception when converting to int
            string b = Console.ReadLine();

            // if the second input is empty only pass one argument
            if (b == "")
            {
                Console.WriteLine(instance.Method1(a));
            }
            else // pass both arguments when b is provided
            {
                Console.WriteLine(instance.Method1(a, Convert.ToInt32(b)));
            }

            // give the user time to peruse the multitude of pixels before him
            Console.ReadLine();
        }
    }
}
