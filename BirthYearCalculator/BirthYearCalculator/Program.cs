using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int birthYear;
                Console.WriteLine("Please enter your age.");
                // get age from user
                int age = Convert.ToInt32(Console.ReadLine());

                // check if age is 0 or less
                if (age < 1)
                {
                    throw new AgeException("Surely you're older than that!");
                }

                // calculate possible birth years and print them to the console
                birthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in either {0} or {1}.", birthYear, --birthYear);

                // express skepticism if age is too high
                if (age > 90)
                {
                    throw new AgeException("I'm not so sure you're that old...");
                }
            }
            catch (AgeException e)
            {
                // print message argument when AgeExceptions are hit
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only positive whole numbers.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again later.");
            }

            Console.Read();
        }
    }
}
