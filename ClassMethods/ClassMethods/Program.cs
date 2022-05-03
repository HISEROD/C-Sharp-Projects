using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the 1,000,000th prime number!");
            // calculate the 1,000,000th prime!
            Console.WriteLine(Operations.NthPrime(1000000));
            Console.WriteLine("\nThese are the first 10 Fibonacci numbers:");
            // calculate 10 Fibonacci numbers
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Operations.NthFibonacci(i));
            }
            Console.WriteLine("\nThese are the first 10 Lucas numbers:");
            // calculate 10 Lucas numbers
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Operations.NthLucas(i));
            }

            Console.WriteLine("\ninput a number greater than zero to find the nth prime, Fibonacci, and Lucas numbers:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Operations.NthPrime(n));
            Console.WriteLine(Operations.NthFibonacci(n));
            Console.WriteLine(Operations.NthLucas(n));

            // Allow user to dig through the ditches and burn through the
            // witches and slam in the back or their Dragula without the
            // need to worry about the terminal closing too quickly.
            Console.ReadLine();
        }
    }
}
