using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy." + "\n" + "Student Daily Report." + "\n\n");
            Console.WriteLine("1. What is your name?");
            // String used for name answer.
            string ans1 = Console.ReadLine();
            Console.WriteLine("2. What course are you on?");
            // String used for course answer.
            string ans2 = Console.ReadLine();
            Console.WriteLine("3. What page number?");
            // Integer used and converted for page number.
            int ans3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4. Do you need help with anything? Please answer \"true\" or \"false\"");
            // Boolean used and converted for true/false answer.
            bool ans4 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("5. Were there any positive experiences you'd like to share? Please give specifics.");
            // String used for experience answer.
            string ans5 = Console.ReadLine();
            Console.WriteLine("6. Is there any other feedback you'd like to provide? Please be specific.");
            string ans6 = Console.ReadLine();
            // String used for feedback answer.
            Console.WriteLine("7. How many hours did you study today?");
            // Integer used and converted for hours studied.
            int ans7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will repsond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
