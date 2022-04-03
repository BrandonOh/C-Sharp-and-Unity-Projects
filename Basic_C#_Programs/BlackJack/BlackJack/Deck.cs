﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> suits = new List<string>() 
            { 
                "Clubs", 
                "Hearts", 
                "Diamonds", 
                "Spades" 
            };

            List<string> faces = new List<string>()
            {
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine",
                "Ten",
                "Jack",
                "Queen",
                "King",
                "Ace"
            };

            foreach (string suit in suits)
            {
                foreach (string face in faces)
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.face = face;
                    Cards.Add(card);
                }
            }
        }
        public List <Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
