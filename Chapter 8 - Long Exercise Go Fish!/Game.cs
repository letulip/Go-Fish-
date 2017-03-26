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
        private List<string> list;
        private TextBox tbxGameProgress;
        private string text;

        public Game(string text, List<string> list, TextBox tbxGameProgress)
        {
            this.text = text;
            this.list = list;
            this.tbxGameProgress = tbxGameProgress;
        }

        internal bool PlayOneRound(int selectedIndex)
        {
            throw new NotImplementedException();
        }

        internal string GetWinnerName()
        {
            throw new NotImplementedException();
        }

        internal string DescribeBooks()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            throw new NotImplementedException();
        }

        internal string DescribePlayerHands()
        {
            throw new NotImplementedException();
        }
    }
}
