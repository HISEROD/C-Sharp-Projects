using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // inherit properties and method from Person class
    class Employee : Person
    {
        // create Id property
        public int Id { get; set; }
    }
}
