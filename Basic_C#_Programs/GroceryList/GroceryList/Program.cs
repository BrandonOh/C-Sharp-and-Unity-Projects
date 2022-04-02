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

            Console.WriteLine("\nGrocery List:");
            for (int i = 0; i <= amount - 1; i++)
            {
                Console.WriteLine(groceryList[i]);
            }

            List<string> superMarket = new List<string>();
            superMarket.Add("Stop n Shop");
            superMarket.Add("King Kullen");
            superMarket.Add("Bravo");
            superMarket.Add("S Mart");
            superMarket.Add("Holiday Farms");

            Console.WriteLine("\nWhat super market would you like to go to?");
            Console.WriteLine("Stop n Shop - King Kullen - Bravo - S Mart - Holiday Farms");
            string marketChoice = Console.ReadLine();
            for (int i = 0; i < superMarket.Count; i++)
            {
                if (marketChoice == superMarket[i])
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    if(i == superMarket.Count - 1)
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }

            List<string> attendees = new List<string>();
            attendees.Add("Bob");
            attendees.Add("Jeremy");
            attendees.Add("Robert");
            attendees.Add("Sadie");
            attendees.Add("Bob");
            attendees.Add("Tom");
            attendees.Add("Jill"); 
            attendees.Add("Brandon");
            attendees.Add("Robert");
            attendees.Add("Tammy");

            Console.WriteLine("\nType a name to search through attendees: ");
            Console.WriteLine("Bob - Jeremy - Robert - Sadie - Tom - Jill");
            
            string name = Console.ReadLine();
            bool foundName = false;

            for (int i = 0; i < attendees.Count; i++)
            {
                if(name == attendees[i])
                {
                    Console.WriteLine(i);
                    foundName = true;
                }
                else
                {
                    if (i == attendees.Count - 1 && foundName == false)
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }

            Console.WriteLine("\n");

            int start = 0;

            List<string> multiples = new List<string>();
            List<string> singles = new List<string>();

            foreach (string element in attendees)
            {
                if(multiples.Contains(element) == true)
                {
                    start++;
                    continue;
                }
                int i = 0;
                for (i = start; i < attendees.Count; i++)
                {
                    if (i == attendees.Count - 1)
                    {
                        singles.Add(attendees[start]);
                    }
                    else if (element == attendees[i + 1])
                    {
                        multiples.Add(attendees[start]);
                break;
                    }
                }
                start++;
            }

            foreach (string element in multiples)
            {
                Console.WriteLine(element + " comes up multiple times.");
            }

            foreach (string element in singles)
            {
                Console.WriteLine(element + " comes up one time.");
            }

            Console.ReadLine();
        }
    }
}