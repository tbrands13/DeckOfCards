using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        List<Card> hand = new List<Card>();
        // Can also use "var" as a type and let program determine the variable type
        public List<Card> Hand
        {get{return hand;}}
        public Card Draw(Deck deck)
        {
            Card c =deck.Deal();
            hand.Add(c);
            return c;
        }

        public Card Discard(Card book)
        {
            hand.Remove(book);
            Console.WriteLine(book);
            return book;
        }
        
    }
}


