using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Please enter your package's weight.");
            byte pkgWeight = Convert.ToByte(Console.ReadLine());
            // ensure that the package is lighter than 50
            // 50 what? No one knows.
            if (pkgWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express.\nSorry for the inconvenience.");
                Console.Read();
                return; // terminate program
            }

            // determine package dimensions
            Console.WriteLine("\nPlease enter your package's width.");
            byte pkgWidth = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\nPlease enter your package's height.");
            byte pkgHeight = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\nPlease enter your package's length.");
            byte pkgLength = Convert.ToByte(Console.ReadLine());

            // ensure that the sum of the dimensions is < 50
            if (pkgLength + pkgWidth + pkgHeight > 50)
            {
                Console.WriteLine("Package too big too be shipped via Package Exress.");
                Console.Read();
                return; // terminate program
            }

            // Calculate shipping cost based on the inverse of the density divided by 100
            Console.WriteLine("\nYour estimated total for shipping this package is: $" +
                (pkgLength * pkgWidth * pkgHeight * pkgWeight / 100) + ".00\nThank you!");

            // Allow user to fixate their gaze upon the open cosole in its natural habitat
            Console.Read();
        }
    }
}
