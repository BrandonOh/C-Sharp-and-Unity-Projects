using System;
using System.Collections.Generic;

namespace DivideList
{
    class Program
    {
        static void Main()
        {
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(18);
            numList.Add(144);
            numList.Add(26);
            numList.Add(128);
            numList.Add(94);

            Console.WriteLine("Please provide a number to divide into the list.");
            

            try
            {
                Console.WriteLine("You are inside the try/catch block");
                int div = Convert.ToInt32(Console.ReadLine());
                foreach (int element in numList)
                {
                    Console.WriteLine(element / div);
                }
            }
            catch (DivideByZeroException ze)
            {
                Console.WriteLine(ze.Message);
            }
            catch (FormatException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.WriteLine("You are outside the try/catch block.");

            Console.ReadLine();
        }
    }
}
