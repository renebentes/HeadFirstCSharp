using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Page366.GoFish
{
    internal class Game
    {
        private List<Player> players;
        private readonly Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            var random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (var player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
                foreach (var player in players)
                    player.TakeCard(stock.Deal());

            foreach (var player in players)
                PullOutBooks(player);
        }

        private bool PullOutBooks(Player player)
        {
            var booksPulled = player.PullOutBooks();
            foreach (var value in booksPulled)
                books.Add(value, player);

            return player.CardCount == 0 ? true : false;
        }

        internal IEnumerable<object> GetPlayerCardName()
        {
            return players[0].GetCardNames();
        }

        internal string DescribeBooks()
        {
            var whoHasWhichBooks = new StringBuilder();
            foreach (var value in books.Keys)
                whoHasWhichBooks.Append($"{books[value].Name} has a book of {Card.Plural(value)}{Environment.NewLine}");
            return whoHasWhichBooks.ToString();
        }

        internal string DescribePlayerHands()
        {
            var description = new StringBuilder();
            for (int i = 0; i < players.Count; i++)
            {
                description.Append($"{players[i].Name} has {players[i].CardCount}");
                if (players[i].CardCount == 1)
                    description.Append($" card.{Environment.NewLine}");
                else
                    description.Append($" cards{Environment.NewLine}");
            }
            description.Append($"The stock has {stock.Count} cards left.");
            return description.ToString();
        }

        internal bool PlayOneRound(int selectedPlayerCard)
        {
            var cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForACard(players, i, stock);

                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += $"{players[i].Name} drew a new hand{Environment.NewLine}";

                    var card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }

                players[0].SortHand();

                if (stock.Count == 0)
                {
                    textBoxOnForm.Text += $"The stock is out of cards. Game over!{Environment.NewLine}";
                    return true;
                }
            }
            return false;
        }

        internal object GetWinnerName()
        {
            var winners = new Dictionary<string, int>();
            foreach (var value in books.Keys)
            {
                var name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }

            var mostBooks = 0;
            foreach (var name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];

            var tie = false;
            var winnerList = new StringBuilder();
            foreach (var name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (winnerList.Length > 0)
                    {
                        winnerList.Append(" and ");
                        tie = true;
                    }
                    winnerList.Append(name);
                }
            winnerList.Append($" with {mostBooks} books");
            return tie ? $"A tie between {winnerList.ToString()}" : winnerList.ToString();
        }
    }
}