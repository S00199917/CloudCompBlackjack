using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CloudCompBlackjack
{
    /// <summary>
    /// Interaction logic for PlayWindow.xaml
    /// </summary>
    public partial class PlayWindow : Window
    {
        public PlayWindow()
        {
            InitializeComponent();
            Deck deck = new Deck(); 

            deck.Shuffle();

            int playerScore = PlayerTurn(deck);
            if(playerScore > 21)
            {
                //lose
            }
            else
            {
                int dealerScore = dealerTurn(deck);
                if(dealerScore > 21)
                {
                    //dealer loses
                }
                else
                {
                    //determine winner
                    winner(dealerScore, playerScore);
                }
            }

        }
        public static int PlayerTurn(Deck deck)
        {
            int playerScore;
            List<Card> playerHand = new List<Card>();

            Card c1 = deck.GetNextCard();
            Card c2 = deck.GetNextCard();
            playerHand.Add(c1);
            playerHand.Add(c2);

            playerScore = getScore(playerHand);

            bool hit = true;
            while(playerScore < 21 & hit)
            {
                //choice to hit or stand

                //if hit give card


                playerScore = getScore(playerHand);

            }
            return playerScore;
        }
        public static int getScore(List<Card> playerHand)
        {
            bool hasAce = false;
            int score = 0, numberOfAces = 0, adjustmentsMade= 0;

            foreach (Card card in playerHand)
            {
                if (card.CardName.Equals("Ace"))
                {
                    hasAce = true;
                    numberOfAces++;
                }

                score += getCardValue(card);
            }

            while(score > 21 && hasAce && (numberOfAces - adjustmentsMade > 0))
            {
                score -= 10;
            }

            return score;

        }
        public static int getCardValue(Card card)
        {
            int value = 0;

            switch (card.CardName)
            {
                case "Ace":
                    value = 11;
                    break;
                case "King":
                    value = 10;
                    break;
                case "Queen":
                    value = 10;
                    break;
                case "Jack":
                    value = 10;
                    break;
                default:
                    value = Convert.ToInt32(card.CardName);
                    break;
            }
            return value;
        }
        public static int dealerTurn(Deck deck)
        {
            int dealerScore = 0;
            List<Card> dealerHand = new List<Card>();

            Card card;
            

            dealerScore = getScore(dealerHand);
            while (dealerScore < 17)
            {
                card = deck.GetNextCard();
                dealerHand.Add(card);
                dealerScore = getScore(dealerHand);

            }
            return dealerScore;
        }
        public static void winner(int dealerScore, int playerScore)
        {
            if (playerScore > dealerScore)
            {
                //player wins
            }
            else
            {
                //dealer wins
            }
        }
    }
}
