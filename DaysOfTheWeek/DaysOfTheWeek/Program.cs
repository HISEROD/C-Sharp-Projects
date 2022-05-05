using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            DayOfTheWeek day;
            // use tryparse to attempt to assign the users input to the DayOfTheWeek variable
            // if this is unsuccessful success will = False
            bool success = Enum.TryParse(Console.ReadLine(), out day);
            try
            {
                // if the parse was unsuccessful, throw an exception
                if (!success)
                {
                    // not sure if this is the right exception type
                    throw new FormatException();
                }
                // if the exception isn't thrown, print the value of 'day'
                Console.WriteLine(day);
            }
            catch (FormatException)
            {
                // super-duper helpful message
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (Exception e)
            {
                // a message that may or may not be helpful if there are unforeseen exceptions
                Console.WriteLine(e.Message);
            }
            finally
            {
                // in the event of an exception, allow the user to review the super-helpful message
                Console.ReadLine();
            }
        }

        // define the DayOfTheWeek enumeration
        enum DayOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
