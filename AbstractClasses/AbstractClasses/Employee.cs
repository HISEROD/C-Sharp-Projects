using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Employee : Person, IQuittable
    {
        // create a special version of SayName that starts with "Employee Name:"
        public override void SayName()
        {
            Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
        }
        // create a Quit method to satisfy the requirements of IQuittable
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
