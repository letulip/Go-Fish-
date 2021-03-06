﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8___Long_Exercise_Go_Fish_
{
    class Player
    {
        string name;
        public string Name { get { return name; } }
        Random rnd;
        Deck cards;
        TextBox textBoxOnForm;

        public int CardCount { get { return cards.Count; } }

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }

        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            cards.SortByValue();
        }

        public Player(string name, Random rnd, TextBox textBoxOnForm)
        {
            this.name = name;
            this.rnd = rnd;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });

            textBoxOnForm.Text += name + " has just joined the game" + Environment.NewLine;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();

            for (int i = 0; i < 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;

                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if(howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(rnd.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck deckToPass = cards.PullOutValues(value);

            textBoxOnForm.Text += name + " has " + deckToPass.Count + " " + Card.Plural(value) + Environment.NewLine;

            return deckToPass;
        }

        public void AskForCard(List<Player> players, int myIndex, Deck stock)
        {
            if(stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values rndValue = GetRandomValue();
                AskForCard(players, myIndex, stock, rndValue);
            }
        }

        public void AskForCard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += name + " asks if anyone has a " + value + Environment.NewLine;

            int totalCardsGiven = 0;

            for (int i = 0; i < players.Count; i++)
            {
                if ( i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0)
                        cards.Add(cardsGiven.Deal());
                }

            }
            if(totalCardsGiven == 0 && stock.Count > 0)
            {
                textBoxOnForm.Text += name + " must draw from the stock." + Environment.NewLine;
                cards.Add(stock.Deal());
            }  
        }
    }
}
