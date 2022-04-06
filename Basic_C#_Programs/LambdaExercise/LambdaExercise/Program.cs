using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                fName = "Jeffery",
                lName = "Wilcox",
                idNum = 001
            };

            Employee employee2 = new Employee()
            {
                fName = "Eiliya",
                lName = "Mcclurg",
                idNum = 002
            };

            Employee employee3 = new Employee()
            {
                fName = "Cheyann",
                lName = "Serio",
                idNum = 003
            };

            Employee employee4 = new Employee()
            {
                fName = "Hailey",
                lName = "Palmer",
                idNum = 004
            };

            Employee employee5 = new Employee()
            {
                fName = "Joe",
                lName = "Tyrrell",
                idNum = 005
            };

            Employee employee6 = new Employee()
            {
                fName = "Saleh",
                lName = "Vandiver",
                idNum = 006

            };

            Employee employee7 = new Employee()
            {
                fName = "Lenna",
                lName = "Peavy",
                idNum = 007
            };

            Employee employee8 = new Employee()
            {
                fName = "Joe",
                lName = "Gallo",
                idNum = 008
            };

            Employee employee9 = new Employee()
            {
                fName = "Kollin",
                lName = "Lacroix",
                idNum = 009
            };

            Employee employee10 = new Employee()
            {
                fName = "Jocelynn",
                lName = "Overton",
                idNum = 010
            };

            List<Employee> employees = new List<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);


            // Foreach Loop
            List<Employee> namesJoe = new List<Employee>();
            foreach(Employee element in employees)
            {
                if(element.fName.Contains("Joe"))
                {
                    namesJoe.Add(element);
                }
            }
            foreach(Employee element in namesJoe)
            {
                Console.WriteLine(element.fName + " " + element.lName + " id: " + element.idNum);
            }
            namesJoe.Clear();

            Console.WriteLine();
            // Lambda Expression
            namesJoe = employees.Where(x => x.fName.Contains("Joe")).ToList();
            foreach (Employee element in namesJoe)
            {
                Console.WriteLine(element.fName + " " + element.lName + " id: " + element.idNum);
            }

            Console.WriteLine();
            //Lambda Expression greater than 5
            List<Employee> idGreater5 = employees.Where(x => (x.idNum > 5)).ToList();
            foreach (Employee element in idGreater5)
            {
                Console.WriteLine(element.fName + " " + element.lName + " id: " + element.idNum);
            }
            Console.ReadLine();
        }
    }
}
