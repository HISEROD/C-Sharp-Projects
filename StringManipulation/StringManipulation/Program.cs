using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Here is the concatenation of \"One \", \"Two \", and \"Three\":");
            // initialize a string using concatenation
            string tripleStr = "One " + "Two " + "Three";
            Console.WriteLine(tripleStr);

            Console.WriteLine("\nHere is the uppercase version of that string:");
            // make the string uppercase
            tripleStr = tripleStr.ToUpper();
            Console.WriteLine(tripleStr);

            Console.WriteLine("\nHere is a StringBuilder built one sentence at a time:");

            // create and append to a StringBuilder object
            StringBuilder buffStr = new StringBuilder("This is a sentence.");
            buffStr.Append(" This is a second sentence.");
            buffStr.Append(" There are two sentences that come before this one.");

            Console.WriteLine(buffStr);

            // Allow user to bask in the presence of the open terminal as it shines forth
            // or at least allow him to read what's on the screen
            Console.ReadLine();
        }
    }
}
