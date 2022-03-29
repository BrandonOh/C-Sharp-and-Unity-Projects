using System;
using System.Text;

namespace StringsExercise
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string firstSent;

            Console.WriteLine("Hello, Whats your name?");
            string name = Console.ReadLine();
            firstSent = "Your name is " + name.ToUpper();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            firstSent += " your " + age + " years old ";
            Console.WriteLine("What is your favorite hobby?");
            string hobby = Console.ReadLine();
            firstSent += "and your favorite hobby is " + hobby + ".";
            Console.WriteLine(firstSent + "\n");
            sb.Append("According to all known laws of aviation, there is no way a bee should be able to fly.\n");
            sb.Append("It's wings are too small to get its fat little body off the ground.\n");
            sb.Append("The bee, of course, flies anyway, because bees don't care what humans think is impossible.\n");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
