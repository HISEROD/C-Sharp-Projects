using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
        // create a Quit method to satisfy the requirements of IQuittable
        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit!", FirstName, LastName);
        }

        // create equal and not-equal operator overloads that compare employee ID's
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
