using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate number object
            Number num = new Number() { Amount = 1.2345678910111213141516171819202122m };
            // print amount property
            Console.WriteLine(num.Amount);
            Console.ReadKey();
        }
        struct Number
        {
            public decimal Amount;
        }
    }
}
