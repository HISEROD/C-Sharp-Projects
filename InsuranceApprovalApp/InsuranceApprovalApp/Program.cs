using System;

namespace InsuranceApprovalApp
{
    class Program
    {
        static void Main()
        {
            // ask driver's age
            Console.WriteLine("What is your age?");
            // save age as byte
            byte age = Convert.ToByte(Console.ReadLine());
            // ask if driver has had a DUI
            Console.WriteLine("Have you ever had a DUI?");
            // save DUI status as boolean
            bool hasHadDUI = Convert.ToBoolean(Console.ReadLine());
            // ask driver's number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            // save number of tickets as byte
            byte tickets = Convert.ToByte(Console.ReadLine());
            // blank line makes it pretty
            Console.WriteLine();

            // use comparisons and boolean logic to determine if driver is qualified
            bool isQualified = age > 15 && !hasHadDUI && tickets < 4;
            // tell driver whether he is qualified for insurance
            Console.WriteLine("Qualified? " + isQualified);

            // allow user to thouroughly engage in the art of reading the console output
            Console.Read();
        }
    }
}
