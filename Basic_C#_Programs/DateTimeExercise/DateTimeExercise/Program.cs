using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            Console.Write("\nPlease provide a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            dateTime = dateTime.AddHours(hours);
            Console.WriteLine(dateTime);

            Console.ReadLine();
        }
    }
}
