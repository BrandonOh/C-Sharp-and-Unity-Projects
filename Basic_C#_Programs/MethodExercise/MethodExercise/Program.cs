using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main()
        {                       
            Console.Write("Please provide a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please provide another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(operations.add(num1 , num2));
            Console.WriteLine(operations.multiply(num1, num2));
            Console.WriteLine(operations.divide(num1, num2));
            Console.ReadKey();
        }
    }
}
