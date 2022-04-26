using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            // title
            Console.WriteLine("---- Anonymous Income Comparison Program ----\n");

            // show user that they are entering data for Person 1
            Console.WriteLine("Person 1");
            // ask user to enter Person 1's hourly wage
            Console.WriteLine("Enter hourly wage:");
            // save Person 1's wage
            decimal p1Wage = Convert.ToDecimal(Console.ReadLine());
            // ask user to enter Person 1's weekly hours
            Console.WriteLine("Enter weekly hours:");
            // save Person 1's hours
            decimal p1Hours = Convert.ToDecimal(Console.ReadLine());
            // add empty line
            Console.WriteLine();

            // same a Person 1's code except for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly wage:");
            decimal p2Wage = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter weekly hours:");
            decimal p2Hours = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            // show the annual salarries of both persons
            Console.WriteLine("Annual salary of Person 1: " + (p1Wage * p1Hours * 52));
            Console.WriteLine("Annual salary of Person 2: " + (p2Wage * p2Hours * 52));
            // add empty line
            Console.WriteLine();

            // show whether Person 1 earns more than Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2? " +
                (p1Wage * p1Hours > p2Wage * p2Hours));

            // maintain visibility of the console until a key is pressed
            // this way, user may remain enthralled for however long their heart desires
            Console.Read();
        }
    }
}
