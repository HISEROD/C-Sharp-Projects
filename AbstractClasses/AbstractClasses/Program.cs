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
            // make a list of employees for science
            List<Employee<byte>> employees = new List<Employee<byte>>()
            {
                new Employee<byte>() { FirstName = "Joe", LastName = "Doe", Id = 1 },
                new Employee<byte>() { FirstName = "John", LastName = "Shmohn", Id = 2 },
                new Employee<byte>() { FirstName = "Lenny", LastName = "Benny", Id = 3 },
                new Employee<byte>() { FirstName = "Joe", LastName = "Yo", Id = 4 },
                new Employee<byte>() { FirstName = "John", LastName = "Benny", Id = 5 },
                new Employee<byte>() { FirstName = "Denny", LastName = "Benny", Id = 6 },
                new Employee<byte>() { FirstName = "Joe", LastName = "Biden", Id = 7 },
                new Employee<byte>() { FirstName = "John", LastName = "Shmohner", Id = 8 },
                new Employee<byte>() { FirstName = "Lenny", LastName = "Shmohnson", Id = 9 },
                new Employee<byte>() { FirstName = "Joe", LastName = "Momma", Id = 10 }
            };

            List<Employee<byte>> joes = new List<Employee<byte>>();
            // get all the joes with a foreach loop
            foreach (Employee<byte> e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    joes.Add(e);
                }
            }

            // get all the joes with a lambda function this time
            joes = employees.Where(x => x.FirstName == "Joe").ToList();

            // make a new list of employees to test a different lambda
            List<Employee<byte>> highIds = new List<Employee<byte>>();
            // get all the dudes with ID's over 5 with another lambda
            highIds = employees.Where(x => x.Id > 5).ToList();

            // partial test
            Console.WriteLine(joes[0].FirstName);
            Console.WriteLine(highIds[0].Id);

            Console.Read();
        }
    }
}
