using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            // make arrays for the user to select elements from
            int[] ints = { 1, 2, 3, 4, 5 };
            string[] strs = { "string 1", "string 2", "string 3", "string 4", "string 5" };

            // prompt user for an index
            Console.WriteLine("Pick an index in [0, 4]");
            // store the given index
            int index = Convert.ToInt32(Console.ReadLine());
            // show the element at the given index if it is in range
            if (0 <= index && index <= 4) { Console.WriteLine(ints[index]); }
            // else tell the user what's wrong
            else { Console.WriteLine("Index out of range."); }

            // same as before
            Console.WriteLine("Pick an index in [0, 4]");
            index = Convert.ToInt32(Console.ReadLine());
            if (0 <= index && index <= 4) { Console.WriteLine(strs[index]); }
            else { Console.WriteLine("Index out of range."); }

            // this time do the same things as above, but with a list
            List<string> strL = new List<string>();
            strL.Add("string list item no. 1");
            strL.Add("string list item no. 2");
            strL.Add("string list item no. 3");

            Console.WriteLine("Pick an index in [0, 2]");
            index = Convert.ToInt32(Console.ReadLine());
            if (0 <= index && index <= 2) { Console.WriteLine(strs[index]); }
            else { Console.WriteLine("Index out of range."); }

            // allow the person to view the results of the indices they've entered
            // for as long as their heart desires
            Console.ReadLine();
        }
    }
}
