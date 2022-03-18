using System;

namespace Math_Challenge
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input a whole number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input another whole number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("Those numbers added to each other is: " + num3);
            num3 = num1 - num2;
            Console.WriteLine("Those numbers subtracted to each other is: " + num3);
            num3 = num1 * num2;
            Console.WriteLine("Those numbers multiplied by each other is: " + num3);
            num3 = num1 / num2;
            Console.WriteLine("Those numbers divided by each other is: " + num3);
            Console.ReadLine();
        }
    }
}
