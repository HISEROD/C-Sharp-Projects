using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect student's name.
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // Determine what course the student is on.
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            // Determine what page of the course the student is on.
            Console.WriteLine("What page number?");
            ushort currentPage = Convert.ToUInt16(Console.ReadLine());

            // Ask if the student needs help with anything.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Allow the student to share any positive experiences.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string prositiveExperiences = Console.ReadLine();

            // Allow the student to share feedback.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string additionalFeedback = Console.ReadLine();

            // Determine how many hours of studying the student has done.
            Console.WriteLine("How many hours did you study today?");
            byte studyHours = Convert.ToByte(Console.ReadLine());

            // Thank the student, inform them of the imminent response from an instructor, and say farewell.
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            // Make the program more inclusive to those who can only read at sub-computer speeds.
            Console.Read();
        }
    }
}
