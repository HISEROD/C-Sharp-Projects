using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate employee
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // call superclass method
            employee.SayName();

            Console.Read();
        }
    }
}
