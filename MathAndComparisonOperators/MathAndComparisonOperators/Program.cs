using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // first line: show user what operation will be done
            Console.WriteLine("Enter a number to be multiplied by 50.");
            // second line: store number that user types
            double number = Convert.ToDouble(Console.ReadLine());
            // third line: show result of foretold operation
            Console.WriteLine(number * 50);

            // same deal...
            Console.WriteLine("Enter a number to be added to 25.");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number + 25);

            Console.WriteLine("Enter a number to be divided by 12.5.");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number / 12.5);

            Console.WriteLine("Enter a number to see if it is greater than 50.");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number > 50);

            Console.WriteLine("Enter a number to see the remainder when divided by 7.");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number % 7);

            // leave console open so that the user can stare at it indefinitely
            // or until they experience a power outage
            // ...or until the heat death of the universe. Whichever comes first.
            Console.Read();
        }
    }
}
