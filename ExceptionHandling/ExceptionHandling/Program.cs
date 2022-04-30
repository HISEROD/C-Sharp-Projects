using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // create a list of ints to be divided by a number from the user
        List<int> ints = new List<int>() { 2, 1, 3, 4, 7, 11, 18, 29, 47, 76, 123, 199 };
        Console.WriteLine("Pick a divisor.");

        try
        {
            // get user input
            int divisor = Convert.ToInt32(Console.ReadLine());
            // display the result of the division for each element in the list
            foreach (int i in ints)
            {
                Console.WriteLine(i + " / " + divisor + " = " + i / divisor);
            }
        }
        // catch possible exceptions
        catch (FormatException)
        {
            Console.WriteLine("Divisor must be a whole number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divisor must be nonzero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("That divisor is too big. Try a smaller number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            // show that the program is finished
            Console.WriteLine("Press any key to terminate the program.");
            // allow the user to behold the glorious output 
            Console.ReadLine();
        }
    }
}
