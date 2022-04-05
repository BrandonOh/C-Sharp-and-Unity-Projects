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
            Employee em = new Employee();
            IQuittable iq = new Employee();

            em.firstName = "Sample";
            em.lastName = "Student";
            em.SayName();

            iq.Quit();

            Console.ReadLine();
        }
    }
}
