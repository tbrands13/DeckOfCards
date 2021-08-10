using System;

namespace DeckOfCards
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Card randCard = new Card("King", "Spade", 13);
            Console.WriteLine(randCard.StringVal);

            Deck deckOne = new Deck();
            deckOne.Deal();
            deckOne.Randomize();
            deckOne.Reset();
             Player playerOne = new Player();
             playerOne.Draw(deckOne);
             playerOne.Discard(randCard);

            // deckOne.PrintCards();
        }
    }
}
