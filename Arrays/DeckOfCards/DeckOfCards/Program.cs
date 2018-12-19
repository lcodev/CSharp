using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deck = new int[52];
            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // initialize the cards
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i;
            }

            // shuffle the cards
            for (int i = 0; i < deck.Length; i++)
            {
                // generate a random idex
                Random rnd = new Random();
                int index = (int)(rnd.Next(0, deck.Length));
                int temp = deck[i];
                deck[i] = deck[index];
                deck[index] = temp;
            }

            // display the first four cards
            for (int i = 0; i < 4; i++)
            {
                string suit = suits[deck[i] / 13];
                string rank = ranks[deck[i] % 13];
                Console.WriteLine("Card number " + deck[i] + ": " + rank + " of " + suit);
            }
        }
    }
}
