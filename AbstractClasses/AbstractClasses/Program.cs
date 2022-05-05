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
            Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 438 };
            employee.Things = new List<string>() { "hammer", "nails", "tapemeasure" };

            Employee<int> employee2 = new Employee<int>() { FirstName = "Sample", LastName = "Student", Id = 438 };
            employee2.Things = new List<int>() { 1, 2, 3, 4 };

            // print employees' things to the console
            foreach (string str in employee.Things)
            {
                Console.WriteLine(str);
            }
            foreach (int integer in employee2.Things)
            {
                Console.WriteLine(integer);
            }


            //employee.SayName();

            //IQuittable quittable = new Employee() { FirstName = "Sample", LastName = "Student" };

            //quittable.Quit();

            //Employee employee2 = new Employee() { FirstName = "Bob", LastName = "Bobson", Id = 324 };

            //Console.WriteLine("employee == employee2: {0}", employee == employee2);
            //Console.WriteLine("employee != employee2: {0}", employee != employee2);



            Console.Read();
        }
    }
}
