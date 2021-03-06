﻿namespace Page331
{
    internal class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get
            {
                return Value + " of " + Suit;
            }
        }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}