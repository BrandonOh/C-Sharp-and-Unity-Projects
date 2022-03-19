using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymour Income Comparison Program" + "\n");
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            int hourRateP1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int hoursWorkedP1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + "Person 2");
            Console.Write("Hourly Rate: ");
            int hourRateP2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int hoursWorkedP2 = Convert.ToInt32(Console.ReadLine());
            int totalP1 = hourRateP1 * hoursWorkedP1 * 52;
            int totalP2 = hourRateP2 * hoursWorkedP2 * 52;
            Console.WriteLine("\n" + "Annual Salary of Person 1: " + "\n" + totalP1);
            Console.WriteLine("Annual Salary of Person 2: " + "\n" + totalP2);
            bool moreMoney = totalP1 > totalP2;
            Console.WriteLine("\n" + "Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreMoney);
            Console.ReadLine();
        }
    }
}
