using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Employee em = new Employee();
            IQuittable iq = new Employee();

            em.firstName = "Sample";
            em.lastName = "Student";
            em.SayName();*/


            /*iq.Quit();*/

            Employee<string> ts = new Employee<string>();
            ts.ts.Add("Tommy");
            ts.ts.Add("Jeremy");
            ts.ts.Add("Carter");
            ts.ts.Add("Bob");
            ts.ts.Add("Samson");

            foreach(string element in ts.ts)
            {
                Console.WriteLine(element);
            }

            Employee<int> il = new Employee<int>();
            il.ts.Add(1);
            il.ts.Add(2);
            il.ts.Add(3);
            il.ts.Add(4);
            il.ts.Add(3);
            il.ts.Add(2);
            il.ts.Add(1);

            foreach (int element in il.ts)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
