using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise60
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    deck.Add(new Card((Rank)i, (Suit)j));
                }
            }
            var shuffledDeck = deck.OrderBy(x => new Random().Next()).ToList();
            Console.WriteLine(shuffledDeck[0].GetCard());
        }
    }
}
