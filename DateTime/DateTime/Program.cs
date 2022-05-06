using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // print current dateTime
        Console.WriteLine(DateTime.Now);
        // store provided hours as a TimeSpan
        Console.WriteLine("Enter a number of hours.");
        TimeSpan hours = new TimeSpan(Convert.ToInt32(Console.ReadLine()), 0, 0);

        // print what time it will be in X hours
        Console.WriteLine("It will be {0} in {1} hours.", (DateTime.Now + hours).ToShortTimeString(), hours.Hours);

        Console.Read();
    }
}
