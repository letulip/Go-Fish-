using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8___Long_Exercise_Go_Fish_
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game(tbxYourName.Text, new List<string> { "Joe", "Bob" }, tbxGameProgress);
            btnStart.Enabled = false;
            btnCardAsk.Enabled = true;
            tbxYourName.Enabled = false;
            UpdateForm();
        }

        private void btnCardAsk_Click(object sender, EventArgs e)
        {
            tbxGameProgress.Text = "";
            if (lbxYourHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(lbxYourHand.SelectedIndex))
            {
                tbxGameProgress.Text += "The winner is... " + game.GetWinnerName();
                tbxBooks.Text = game.DescribeBooks();
                btnCardAsk.Enabled = false;
            }
            else
                UpdateForm();
        }

        private void UpdateForm()
        {
            lbxYourHand.Items.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                lbxYourHand.Items.Add(cardName);
            tbxBooks.Text = game.DescribeBooks();
            tbxGameProgress.Text += game.DescribePlayerHands();
            tbxGameProgress.SelectionStart = tbxGameProgress.Text.Length;
            tbxGameProgress.ScrollToCaret();
        }
    }
}
