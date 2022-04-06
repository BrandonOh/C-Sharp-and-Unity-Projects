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
            List<string> employees = new List<string>()
            {
               "Jeffrey Wilcox ID: 024",
               "Eiliyah Mcclurg ID: 089",
               "Cheyann Serio ID: 004",
               "Hailey Palmer ID: 892",
               "Joe Tyrrell ID: 405",
               "Saleh Vandiver ID: 345",
               "Lenna Peavy ID: 607",
               "Joe Gallo ID: 023",
               "Kollin Lacroix ID: 001",
               "Jocelynn Overton ID: 782"
            };

            // Foreach Loop
            List<string> namesJoe = new List<string>();
            foreach(string element in employees)
            {
                if(element.Contains("Joe"))
                {
                    namesJoe.Add(element);
                }
            }
            foreach(string element in namesJoe)
            {
                Console.WriteLine(element);
            }
            namesJoe.Clear();

            Console.WriteLine();
            // Lambda Expression
            namesJoe = employees.Where(x => x.Contains("Joe")).ToList();
            foreach (string element in namesJoe)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            //Lambda Expression greater than 5
            List<string> idGreater5 = employees.Where(x => (Convert.ToInt32(x.Substring(x.IndexOf(": ") + 2)) > 5)).ToList();
            foreach (string element in idGreater5)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
