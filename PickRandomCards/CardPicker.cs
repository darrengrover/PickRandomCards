using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i=0 ; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomeValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            List<string> suits = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spades" };
            Random random = new Random();
            int index = random.Next(suits.Count);
            return suits[index];
        }

        private static string RandomeValue()
        {
            List<string> values = new List<string>() { "Ace", "Two", "Three", "Four","Five","Six","Seven","Eight","Nine","Jack","Queen","King"};
            Random random = new Random();
            int index = random.Next(values.Count);
            return values[index];
        }
    }
}
