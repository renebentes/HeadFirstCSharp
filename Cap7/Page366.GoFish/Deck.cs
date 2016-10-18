using System;
using System.Collections.Generic;

namespace Page366.GoFish
{
    internal class Deck
    {
        private List<Card> cards;
        private readonly Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Values)value, (Suits)suit));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card Deal(int index)
        {
            var cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            var newCards = new List<Card>();
            while (cards.Count > 0)
            {
                var cardToMove = random.Next(cards.Count);
                newCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            var cardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                cardNames[i] = cards[i].Name;
            return cardNames;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparerByValue());
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValues(Values value)
        {
            foreach (var card in cards)
                if (card.Value == value)
                    return true;

            return false;
        }

        public Deck PullOutValues(Values value)
        {
            var deckToReturn = new Deck(new Card[] { });
            for (var i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(cards[i]);

            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            var numberOfCards = 0;
            foreach (var card in cards)
                if (card.Value == value)
                    numberOfCards++;

            return numberOfCards == 4 ? true : false;
        }
    }
}