using System;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            // -- discover whether your age is a prime number --

            Console.WriteLine("Please enter your age.");
            byte age = Convert.ToByte(Console.ReadLine());

            byte i = Convert.ToByte(Math.Sqrt(age));

            // if the user types an age of 2, the do while loop
            // will still execute whereas a while loop would not
            do
            {
                // check if age is divisible by i
                if (age % i == 0)
                {
                    Console.WriteLine("Your age is not prime.");
                    break;
                }
                if (i == 2)
                {
                    // at this point we know age is prime
                    Console.WriteLine("Your age is prime!");
                    break;
                }
                i--;
            }
            while (i >= 2);

            // wait until the user presses a key
            Console.ReadLine();


            // ---------- print a tree to the console ----------

            // inform user of the tree that will be printed within a fraction of a second
            Console.WriteLine("Here's a tree:");

            // reuse i variable
            i = 10;

            string treeText = "";
            while (i > 0)
            {
                // use i to determine how many spaces and how many #'s are necessary for each line
                treeText +=
                    "          ".Substring(10 - i) +              // fewer spaces as i increases
                    "####################".Substring(2 * i - 1) + // more #'s as i increases
                    '\n';                                         // newline
                i--;
            }

            // show the tree
            Console.Write(treeText);

            // allow user to become addicted to the tree in the console by
            // only terminating the program after they have pushed a button.
            Console.Read();
        }
    }
}
