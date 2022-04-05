using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    class Program
    {
        static void Main()
        {         
            Employee em = new Employee();
            Employee em2 = new Employee();

            em.id = "1";
            em2.id = "1";

            Console.WriteLine(em == em2);
            Console.WriteLine(em != em2);
            Console.ReadLine();
        }
    }
}
