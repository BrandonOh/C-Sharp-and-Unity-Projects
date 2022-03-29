using System;

namespace Approval_Program
{
    class Program
    {
        static void Main()
        {
            bool qualified;
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever had a DUI? ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.Write("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            if ((age >= 15) && (DUI == false) && (tickets <= 3))
            {
                qualified = true;
            }
            else
            {
                qualified = false;
            }
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
