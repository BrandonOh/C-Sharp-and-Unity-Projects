using System;
using System.Collections.Generic;

namespace GroceryList
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many things would you like to add to your grocery list: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            string[] groceryList = new string[amount];

            for (int i = 1; i < amount + 1; i++)
            {
                Console.Write("Item number " + i + ": ");
                groceryList[i - 1] = Console.ReadLine();
            }

            Console.Write("\nGrocery List:");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(groceryList[i]);
            }
            Console.ReadLine();
        }
    }
}