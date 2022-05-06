using System;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for a number
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();

            // create a file path for log.txt
            string path = "C:/tmp/log.txt";

            // write the provided number to a new line in the file
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(number);
            }

            // show log location
            Console.WriteLine("Logged \"{0}\" to file: {1}\n\n", number, path);

            // print the log
            string logText = File.ReadAllText(path);
            Console.WriteLine("See log below:\n\n" + logText);

            Console.Read();
        }
    }
}
