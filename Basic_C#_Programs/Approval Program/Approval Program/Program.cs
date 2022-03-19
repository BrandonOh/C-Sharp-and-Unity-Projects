using System;

namespace Approval_Program
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever had a DUI? ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.Write("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = ((age > 15) && (DUI == false) && (tickets <= 3));
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
