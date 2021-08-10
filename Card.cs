using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    interface IRandomizer
    {
        void Randomize();

    }
        public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;

        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }

    }
}


