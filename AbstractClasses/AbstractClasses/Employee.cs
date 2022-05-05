using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
        // create a Quit method to satisfy the requirements of IQuittable
        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit!", FirstName, LastName);
        }

        // add equal and not-equal operator overloads that compare employee ID's
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
