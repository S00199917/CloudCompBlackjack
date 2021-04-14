using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCompBlackjack
{
    public class Deck
    {
        private int currentCard;

        private List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();

            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

            int suitNumber = 0, deckNumber = 0;

            for (int i = 0; i < 52; i++)
            {
                Card c = new Card();

                suitNumber = (i + 1) % 13;

                switch (suitNumber)
                {
                    case 1:
                        c.CardName = "Ace";
                        break;
                    case 11:
                        c.CardName = "Jack";
                        break;
                    case 12:
                        c.CardName = "Queen";
                        break;
                    case 0:
                        c.CardName = "King";
                        break;
                    default:
                        c.CardName = suitNumber.ToString();
                        break;
                }//end of switch

                c.Suit = suits[deckNumber];
                deck.Add(c);

                //if the card is a king, move to next suit
                if (suitNumber == 0)
                    deckNumber++;

            }
        }

        public void Shuffle()
        {
            Random r = new Random();

            for (int i = 0; i < 52; i++)
            {
                int randomNumber = r.Next(0, 52);
                Card temp = deck[randomNumber];
                deck[randomNumber] = deck[i];
                deck[i] = temp;
            }
        }

        public Card GetNextCard()
        {
            return deck.ElementAt(currentCard++);
        }

        public void DisplayCards()
        {
            foreach (Card c in deck)
            {
                Console.WriteLine("{0} of {1}", c.CardName, c.Suit);
            }
        }
    }
}
