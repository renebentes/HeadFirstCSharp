using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Page366.GoFish
{
    internal class Player
    {
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public string Name { get; private set; }

        public int CardCount
        {
            get
            {
                return cards.Count;
            }
        }

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            Name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            cards = new Deck(new Card[] { });
            this.textBoxOnForm.Text = $"{name} has just joined the game {Environment.NewLine}";
        }

        public IEnumerable<Values> PullOutBooks()
        {
            var books = new List<Values>();
            for (var i = 1; i <= 13; i++)
            {
                var value = (Values)i;
                var howMany = 0;
                for (var card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    for (var card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            var randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            var cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += $"{Name} has {cardsIHave.Count} {Card.Plural(value)}{Environment.NewLine}";
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            var randomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, randomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += $"{Name} asks if anyone has a {value}{Environment.NewLine}";
            var totalCardsGiven = 0;
            for (var i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    var player = players[i];
                    var cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0)
                        cards.Add(cardsGiven.Deal());
                }
            }

            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += $"{Name} must draw from the stock.{Environment.NewLine}";
                cards.Add(stock.Deal());
            }
        }

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }

        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            cards.SortByValue();
        }
    }
}