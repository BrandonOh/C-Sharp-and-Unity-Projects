using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Operation.multBy100(4));
            Console.WriteLine(Operation.multBy100(20.5M));
            Console.WriteLine(Operation.multBy100("144"));
            Console.ReadLine();
        }
    }
}
