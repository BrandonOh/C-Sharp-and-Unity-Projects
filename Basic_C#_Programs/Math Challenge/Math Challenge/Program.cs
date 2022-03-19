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
            int answer = 0;
            answer = num1 + num2;
            Console.WriteLine("Those numbers added to each other is: " + answer);
            answer = num1 - num2;
            Console.WriteLine("Those numbers subtracted to each other is: " + answer);
            answer = num1 * num2;
            Console.WriteLine("Those numbers multiplied by each other is: " + answer);
            answer = num1 / num2;
            Console.WriteLine("Those numbers divided by each other is: " + answer);
            Console.Write("Please input your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please input your last name: ");
            string lname = Console.ReadLine();
            string fullname = fname + " " + lname;
            Console.WriteLine("Your full name is: " + fullname);
            Console.Write("Please enter another number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            answer = num3 * 50;
            Console.WriteLine("That number multiplied by 50 is: " + answer);
            answer = num3 + 25;
            Console.WriteLine("That number added with 25 is: " + answer);
            double answerDec = num3 / 12.5;
            Console.WriteLine("That number divided by 12.5 is: " + answerDec);
            bool isGreater = num3 > 50;
            Console.WriteLine("Is that number greater than 50: " + isGreater);
            answer = num3 % 7;
            Console.WriteLine("The remainder of that number divided by 7 is: " + answer);
            Console.ReadLine();
        }
    }
}
