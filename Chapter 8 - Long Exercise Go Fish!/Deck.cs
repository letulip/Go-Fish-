using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___Long_Exercise_Go_Fish_
{
    class Deck
    {
        private List<Card> cards;
        private Random rnd = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < 4; suit++)
                for (int value = 0; value < 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public void Shuffle()
        {
            List<Card> shuffleDeck = new List<Card>();

            while(cards.Count > 0)
            {
                int cardToMove = rnd.Next(cards.Count);
                shuffleDeck.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = shuffleDeck;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                cardNames[i] = cards[i].Name;

            return cardNames;
        }

        public void SortByValue()
        {
            cards.Sort(new SortCards());
        }

        public bool ContainsValue(Values value)
        {
            foreach (Card c in cards)
                if (c.Value == value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });

            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            int numberOfCards = 0;
            foreach (Card c in cards)
                if (c.Value == value)
                    numberOfCards++;
            if (numberOfCards == 4)
                return true;
            else
                return false;
        }
    }
}
