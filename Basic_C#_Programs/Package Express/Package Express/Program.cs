using System;

namespace Package_Express
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimension = width + height + length;
            if(dimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int quota = ((width * height * length) * weight )/ 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quota + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
