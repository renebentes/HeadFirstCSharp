using System;
using System.Collections.Generic;

namespace Page351
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();
            var cards = new List<Card>();

            Console.WriteLine("Five random cards:");
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Values)random.Next(1, 14),
                    (Suits)random.Next(4)));

                Console.WriteLine(cards[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Those same cards, sorted:");
            cards.Sort(new CardComparerByValue());
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }

            Console.ReadKey();
        }
    }
}