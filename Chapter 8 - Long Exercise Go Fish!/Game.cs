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
                    players[player].TakeCard(stock[stock.Count]);

            foreach (Player p in players)
                p.PullOutBooks();
        }

        internal bool PlayOneRound(int selectedIndex)
        {
            Card selectedCard = new Card((Suits)selectedIndex, (Values)selectedIndex);
            for(int i = 0; i < players.Count; i++)
            {
                players[i].AskForCard(players, i, stock, (Values)selectedIndex);
                if(PullOutBooks(players[i]))
                    players[i].TakeCard(selectedCard);
            }
            players[0].SortHand();

            if (stock == null)
            {
                tbxGameProgress.Text += "The stock is out of cards. Game over!" + Environment.NewLine;
                return true;
            }
            else
                return false;
            
        }

        public bool PullOutBooks(Player player)
        {
            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        internal string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach(Values value in books.Keys)
            {

            }
            
        }

        internal string DescribeBooks()
        {
            string booksDesc = "";

            foreach (Player p in players)
                booksDesc += p.Name + " has book of " + p.PullOutBooks() + Environment.NewLine;

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
