using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumExercise
{
    class Program
    {
        static void Main()
        {
            Week week = new Week();

            Console.Write("Please enter the current day of the week: ");
            string day = Console.ReadLine();
            try
            {
                week.days = (Days)Enum.Parse(typeof(Days), day);
                Console.WriteLine(week.days);
            }
            catch
            {
                Console.Write("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
