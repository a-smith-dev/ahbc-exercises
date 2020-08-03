using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace Exercise60
{
    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public Rank Rank { get; }

        public Suit Suit { get; }

        public string GetCard()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
