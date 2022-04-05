﻿using System;
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
            Game game = new Game();
            game.Dealer = "Brandon";
            game.Name = "BlackJack";

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        /*public static Deck Shuffle(Deck deck, int times)
        {
            for (int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
            }
            return deck;
        }*/
    }
}
