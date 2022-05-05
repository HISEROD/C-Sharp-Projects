using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate employee
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // call superclass method
            employee.SayName();

            // use polymorphism to instantiate an IQuittable object with the Employee constructor
            IQuittable quittable = new Employee();

            quittable.Quit();
        }
    }
}
