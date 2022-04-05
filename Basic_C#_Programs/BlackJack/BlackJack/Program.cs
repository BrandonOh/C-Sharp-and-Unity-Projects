using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJackGame game = new BlackJackGame();
            game.Players = new List<string>()
            {
                "Brandon",
                "Brock",
                "Samson"
            };
            game.ListPlayer();
            Console.ReadLine();
            /*Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();*/
        }
    }
}
