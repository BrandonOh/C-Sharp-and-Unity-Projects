﻿using System;
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
            Operation operation = new Operation();

            int num2 = 0;

            Console.WriteLine(Operation.multBy100(4));
            Console.WriteLine(Operation.multBy100(20.5M));
            Console.WriteLine(Operation.multBy100("144"));

            Console.Write("Please provide a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please provide another number (if left empty 15 will be used): ");
            try 
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            int num3 = Operation.multBy15(num1);
            
            Console.WriteLine(num3);
            Console.ReadLine();
        }
    }
}
