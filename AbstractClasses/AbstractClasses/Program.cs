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
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 438 };
            // call superclass method
            employee.SayName();

            // use polymorphism to instantiate an IQuittable object with the Employee constructor
            //IQuittable quittable = new Employee() { FirstName = "Sample", LastName = "Student" };

            // call the Quit method of the Employee
            //quittable.Quit();

            // instantiate another employee for == operator test
            Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Bobson", Id = 324 };

            // compare the two employees
            Console.WriteLine("employee == employee2: {0}", employee == employee2);
            Console.WriteLine("employee != employee2: {0}", employee != employee2);

            Console.Read();
        }
    }
}
