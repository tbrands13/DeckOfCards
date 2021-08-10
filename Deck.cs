using System;
using System.Collections.Generic;

namespace DeckOfCards
{

    public class Deck : IRandomizer
    {
        private List<Card> cards;


        public Deck()
        {
            cards = new List<Card>();
            fillDeck();
        }

        private void fillDeck()
        {
            Console.WriteLine("Add cards to the deck");
            
            string[] suits = {"Spade", "Heart", "Club", "Diamond" };
            for(int i = 0; i < suits.Length; i++)
            {
                for(int num = 1; num <= 13; num++)
                {
                    // Console.WriteLine(suits[i]);
                    // Console.WriteLine(num);
                    string  stringVal;
                    switch(num)
                        {
                        case 1:
                        stringVal = "Ace";
                        break;
                        case 11:
                        stringVal = "Jack";
                        break;
                        case 12:
                        stringVal = "Queen";
                        break;
                        case 13:
                        stringVal = "King";
                        break;
                        default:
                        stringVal = num.ToString();
                        break;
                        }
                        cards.Add(new Card(stringVal, suits[i],num));
                }
            }
        }

        public void PrintCards()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"{card.StringVal} of {card.Suit}s");
            }
        }

        public void Randomize()
        {
            Random rand = new Random();

            for(int i = 0; i < cards.Count; i++)
            {

                int randIndex = rand.Next(cards.Count);

                Card temp = cards[i];
                cards[i] = cards[randIndex];
                cards[randIndex] = temp;
            }
        }

        public Card Deal()
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public void Reset()
        {
            fillDeck();
        }
    }
}