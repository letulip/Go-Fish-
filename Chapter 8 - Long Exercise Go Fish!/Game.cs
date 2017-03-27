using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8___Long_Exercise_Go_Fish_
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox tbxGameProgress;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox tbxGameProgress)
        {
            Random rnd = new Random();
            this.tbxGameProgress = tbxGameProgress;
            players = new List<Player>();
            players.Add(new Player(playerName, rnd, tbxGameProgress));
            
            foreach (string opponent in opponentNames)
                players.Add(new Player(opponent, rnd, tbxGameProgress));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        public void Deal()
        {
            stock.Shuffle();

            for (int card = 0; card < 5; card++)
                for (int player = 0; player < players.Count; player++)
                    players[player].TakeCard(stock.Deal());

            foreach (Player p in players)
                p.PullOutBooks();
        }

        internal bool PlayOneRound(int selectedIndex)
        {
            Values selectedCard = players[0].Peek(selectedIndex).Value;
            for(int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForCard(players, 0, stock, selectedCard);
                else
                    players[i].AskForCard(players, i, stock);

                if (PullOutBooks(players[i]))
                {
                    tbxGameProgress.Text += players[i].Name + " drew a new hand" + Environment.NewLine;

                    int card = 1;

                    while ( card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
            }
            players[0].SortHand();

            if (stock.Count == 0)
            {
                tbxGameProgress.Text += "The stock is out of cards. Game over!" + Environment.NewLine;
                return true;
            }
            else
                return false;
            
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();

            foreach (Values v in booksPulled)
                books.Add(v, player);

            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        internal string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach(Values v in books.Keys)
            {
                string name = books[v].Name;

                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }

            int mostBooks = 0;

            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];

            bool tie = false;
            string winnerList = "";

            foreach(string name in winners.Keys)
                if(winners[name] == mostBooks)
                {
                    if (!string.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }

                    winnerList += name;
                }
            winnerList += " with " + mostBooks + " books ";

            if (tie)
                return "A tie between " + winnerList;
            else
                return winnerList;
        }

        internal string DescribeBooks()
        {
            string booksDesc = "";

            foreach (Values v in books.Keys)
                booksDesc += books[v].Name + " has a book of " + Card.Plural(v) + Environment.NewLine;

            return booksDesc;
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        internal string DescribePlayerHands()
        {
            string description = "";

            foreach (Player p in players)
            {
                description += p.Name + " has " + p.CardCount;
                if (p.CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }

            description += "The stock has " + stock.Count + " cards left." + Environment.NewLine;

            return description;
        }
    }
}
