using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p285Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 instance = new Class1();

            // get user input
            Console.WriteLine("enter a number");
            int input = Convert.ToInt32(Console.ReadLine());

            // call void method (outputs half the argument)
            instance.Method(input);

            Console.Read();
        }
    }
}
