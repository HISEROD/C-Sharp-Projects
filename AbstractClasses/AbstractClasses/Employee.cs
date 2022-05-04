using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Employee : Person
    {
        // create a special version of SayName that starts with "Employee Name:"
        public override void SayName()
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
    }
}
