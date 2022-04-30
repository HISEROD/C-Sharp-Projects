using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --------------
        // -- PART ONE --
        // --------------
        Console.WriteLine("PART I\n");
        // create an array of strings to be modified
        string[] strAr = { "alpha ", "beta ", "delta ", "gamma ", "eta ", "theta ", "upsilon ", "omega " };
        Console.WriteLine("Please enter some text");
        string someText = Console.ReadLine();

        // add the text that the user entered to the end of each element
        for (int i = 0; i < strAr.Length; i++)
        {
            strAr[i] += someText;
        }

        // print all of the elements which now have the user's string on the end
        for (int i = 0; i < strAr.Length; i++)
        {
            Console.WriteLine(strAr[i]);
        }


        // --------------
        // -- PART TWO --
        // --------------
        Console.WriteLine("\n\nPART II\n");
        // an infinite loop ↓
        //while (true)
        //{
        //    Console.WriteLine("To infinity and beyond!");
        //}

        // fixed the loop by adding a comparison that checks if the iterator is below 2
        int whileIterator = 0;
        while (whileIterator < 2)
        {
            Console.WriteLine("finite loop");
            whileIterator++;
        }


        // ----------------
        // -- PART THREE --
        // ----------------
        Console.WriteLine("\n\nPART III\n");
        // a loop that uses less than for its condition
        while (whileIterator < 10)
        {
            Console.WriteLine("whileIterator is less than 10");
            whileIterator++;
        }

        // a loop that uses less than or equal to for its condition
        while (whileIterator <= 10)
        {
            Console.WriteLine("whileIterator is less than or equal to 10");
            whileIterator++;
        }


        // ---------------
        // -- PART FOUR --
        // ---------------
        Console.WriteLine("\n\nPART IV\n");
        // create a list of unique strings
        List<string> uniqueStrings = new List<string>() { "alpha", "beta", "delta", "gamma", "eta", "theta", "upsilon", "omega", "xi", "chi", "rho", "sigma", "lambda", "zeta", "phi", "psi", "tau", "pi", "epsilon" };
        // prompt user for a search string
        Console.WriteLine("Search the selection of popular Greek letters (e.g. \"alpha\"):");
        string search = Console.ReadLine();
        // add a boolean to keep track of whether the string was found in the list
        bool foundString = false;

        // search for the user's string
        foreach (string str in uniqueStrings)
        {
            // if found set to true
            foundString = str == search; 
            if (foundString)
            {
                // display the matching string
                Console.WriteLine("The index of the term you searched for is: " + uniqueStrings.IndexOf(str));
                // terminate the loop to prevent foundString from being set back to false
                break;
            }
        }

        // if the search string was not found, inform user
        if (!foundString)
        {
            Console.WriteLine("No matching string found");
        }


        // ---------------
        // -- PART FIVE --
        // ---------------
        Console.WriteLine("\n\nPART V\n");
        // create a list containing multiple duplicates
        List<string> p5List = new List<string>() { "alpha", "beta", "alpha", "beta", "beta" };
        // add a variable to keep track of how many instances of the user's string are found
        byte count = 0;
        // prompt user for a string
        Console.WriteLine("Enter \"alpha\" or \"beta\"");
        search = Console.ReadLine();

        // iterate through the whole list
        for (byte i = 0; i < p5List.Count; i++)
        {
            // display indices of matches and update the count
            if (p5List[i] == search)
            {
                count++;
                Console.WriteLine("found at index " + i);
            }
        }
        // inform user if none are found
        if (p5List.IndexOf(search) == -1)
        {
            Console.WriteLine("input is not on the list");
        }


        // --------------
        // -- PART SIX --
        // --------------
        Console.WriteLine("\n\nPART VI\n");
        // create a list containing a few duplicate entries
        List<string> p6List = new List<string>() { "alpha", "psi", "beta", "alpha", "delta", "beta", "beta", "gamma", "psi" };
        // create a list to store each unique entry found
        List<string> appeared = new List<string>();

        // loop over each element
        foreach (string str in p6List)
        {
            // if the element has been found before, tell the user
            if (appeared.IndexOf(str) != -1)
            {
                Console.WriteLine(str + " has appeared before");
            }
            // otherwise, add the new element to the 'appeared' list and tell the user
            else
            {
                appeared.Add(str);
                Console.WriteLine(str + " is new");
            }
        }

        Console.ReadLine();
    }
}
