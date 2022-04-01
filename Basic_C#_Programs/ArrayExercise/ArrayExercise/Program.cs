using System;
using System.Collections.Generic;

namespace ArrayExercise
{
    class Program
    {
        static void Main()
        {
            string[] arrayStrings = new string[5] { "Bob", "Rick", "Abby", "John", "Jane" };
            int[] arrayInt = new int[5] { 16, 24, 13, 28, 31 };

            Console.WriteLine("Pick a number between 1-5 to find the name and age of a person.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 5 || num < 0)
            {
                Console.WriteLine("That number is not within the range.");
                Console.ReadLine();
            }
            else
            {
                num -= 1;
                Console.WriteLine(arrayStrings[num] + " " + arrayInt[num]);
                Console.ReadLine();
            }

            List<string> occupation = new List<string>();
            occupation.Add("Police");
            occupation.Add("Teacher");
            occupation.Add("Banker");
            occupation.Add("Manager");
            occupation.Add("Cook");

            Console.WriteLine("Pick a number between 1-5 to find occupation name.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5 || num1 < 0)
            {
                Console.WriteLine("That number is not within the range.");
                Console.ReadLine();
            }
            else
            {
                num1 -= 1;
                Console.WriteLine(occupation[num1]);
                Console.ReadLine();
            }
        }
    }
}
