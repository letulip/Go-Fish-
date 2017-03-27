using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___Long_Exercise_Go_Fish_
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }

    public enum Values
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }


    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
