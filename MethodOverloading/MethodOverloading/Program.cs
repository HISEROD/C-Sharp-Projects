using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            MyClass Instance1 = new MyClass();
            // get user input
            Console.WriteLine("Enter a number to be passed to Method1 as an integer:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            // call Method1 and pass the user's integer as an argument
            Console.WriteLine(MyClass.Method1(userInput1));

            // instantiate the class again
            MyClass Instance2 = new MyClass();
            // get user input again
            Console.WriteLine("Enter a number to be passed to Method1 as a decimal:");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            // call Method1 and pass the user's decimal as an argument
            Console.WriteLine(MyClass.Method1(userInput2));

            // instantiate the class yet again
            MyClass Instance3 = new MyClass();
            // get user input yet again
            Console.WriteLine("Enter a number to be passed to Method1 as a string:");
            string userInput3 = Console.ReadLine();
            // call Method1 and pass the user's string as an argument
            Console.WriteLine(MyClass.Method1(userInput3));

            // Let not the console close so hastily, lest the user see not the fruit thereof.
            Console.ReadLine();
        }
    }
}
