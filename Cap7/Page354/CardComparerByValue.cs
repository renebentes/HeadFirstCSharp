﻿using System.Collections.Generic;

namespace Page354
{
    internal class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
            {
                return 1;
            }

            if (x.Value < y.Value)
            {
                return -1;
            }

            if (x.Suit > y.Suit)
            {
                return 1;
            }

            if (x.Suit < y.Suit)
            {
                return -1;
            }

            return 0;
        }
    }
}