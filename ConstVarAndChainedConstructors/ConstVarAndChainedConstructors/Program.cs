using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarAndChainedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a constant float to store the mathematical circle constant tau
            const float TAU = 6.2831853f;
            Console.WriteLine("the const TAU equals approximately " + TAU);

            // use implicit typing with the new var keyword!
            var awesomeVariable = new ChainedConstuctorClass(TAU);
            Console.WriteLine("the var of type awesomeVariable has an X property equal to " + awesomeVariable.X);

            Console.Read();
        }
    }
}
