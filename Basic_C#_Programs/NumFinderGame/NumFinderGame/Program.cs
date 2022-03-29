using System;

namespace NumFinderGame
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            bool playing = true;

            Console.WriteLine("Wanna play a guessing game?");
            string answer = Console.ReadLine();
            if (answer == "no")
            {
                playing = false;
            }
            while (playing == true)
            {
                Console.WriteLine("Pick a positive max number: ");
                int maxNum = Convert.ToInt32(Console.ReadLine());
                int choosenNum = rnd.Next(1, (maxNum + 1));
                Console.WriteLine("I have chosen number, try to guess it! If you can't figure it out type quit." + "answer:" + choosenNum);
                do
                {
                    string guess = Console.ReadLine();
                    if (Convert.ToInt32(guess) == choosenNum)
                    {
                        Console.WriteLine("That is correct!");
                        playing = false;
                    }
                    else if (guess == "quit")
                    {
                        Console.WriteLine("To bad you couldn't figure it out. The number was " + choosenNum);
                        playing = false;
                    }
                    else if (Convert.ToInt32(guess) < choosenNum)
                    {
                        Console.WriteLine("The number I'm thinking of is higher.");
                    }
                    else if (Convert.ToInt32(guess) > choosenNum)
                    {
                        Console.WriteLine("The number I'm thinking of is lower.");
                    }
                }
                while (playing == true);
            }
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
