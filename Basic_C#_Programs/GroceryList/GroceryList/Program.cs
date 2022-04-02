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

            // Creates new array and sets the array max to input number.
            string[] groceryList = new string[amount];

            // Addeds items to array one at a time.
            for (int i = 1; i < amount + 1; i++)
            {
                Console.Write("Item number " + i + ": ");
                groceryList[i - 1] = Console.ReadLine();
            }

            // Displays each item on grocery array on each line.
            Console.WriteLine("\nGrocery List:");
            for (int i = 0; i <= amount - 1; i++)
            {
                Console.WriteLine(groceryList[i]);
            }

            //List of Super Markets.
            List<string> superMarket = new List<string>();
            superMarket.Add("Stop n Shop");
            superMarket.Add("King Kullen");
            superMarket.Add("Bravo");
            superMarket.Add("S Mart");
            superMarket.Add("Holiday Farms");

            Console.WriteLine("\nWhat super market would you like to go to?");
            Console.WriteLine("Stop n Shop - King Kullen - Bravo - S Mart - Holiday Farms");
            string marketChoice = Console.ReadLine();

            // Returns at what point the element it at.
            for (int i = 0; i < superMarket.Count; i++)
            {
                // Compares if text is same as element.
                if (marketChoice == superMarket[i])
                {
                    Console.WriteLine(i);
                    break;
                }
                // If nothing is matched send invalid input text.
                else
                {
                    if(i == superMarket.Count - 1)
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }

            // List of Names with some repeating.
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
            attendees.Add("Robert");


            Console.WriteLine("\nType a name to search through attendees: ");
            Console.WriteLine("Bob - Jeremy - Robert - Sadie - Tom - Jill");
            
            string name = Console.ReadLine();
            // Bool value to see if a name is found at all.
            bool foundName = false;

            for (int i = 0; i < attendees.Count; i++)
            {
                // Displays what element the name being searched for is on.
                if(name == attendees[i])
                {
                    Console.WriteLine(i);
                    foundName = true;
                }
                else
                {
                    // Checks to see if it is at the end of loop and that no name is found, avoids multiple lines of invalid input.
                    if (i == attendees.Count - 1 && foundName == false)
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }

            Console.WriteLine("\n");

            int start = 0;

            // Two lists for if multiple names have come up or if only name came up once.
            List<string> multiples = new List<string>();
            List<string> singles = new List<string>();

            // Goes through each element in attendees list.
            foreach (string element in attendees)
            {
                // Checks the multiples list to see if name has already been seen, if so move to next iteration in foreach.
                if(multiples.Contains(element) == true)
                {
                    start++;
                    continue;
                }
                int i = 0;
                // Checks each element after current element and then adds to multiple of singles list.
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

            // Afterward text for what comes up multiple times and what comes up once. Only shows text for each name once.
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