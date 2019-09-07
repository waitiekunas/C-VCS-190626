using BlackJack.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameElements
{
    public class DeckOfCards
    {
        private List<Card> deckOfCards;
        private readonly int NUMBER_OF_DECKS = 6;
        private Dictionary<string, int> cardValues;


        private void CreateCardValues()
        {
            cardValues.Add(CardValue.ACE.ToString(), 11);
            cardValues.Add(CardValue.TWO.ToString(), 2);
            cardValues.Add(CardValue.THREE.ToString(), 3);
            cardValues.Add(CardValue.FOUR.ToString(), 4);
            cardValues.Add(CardValue.FIVE.ToString(), 5);
            cardValues.Add(CardValue.SIX.ToString(), 6);
            cardValues.Add(CardValue.SEVEN.ToString(), 7);
            cardValues.Add(CardValue.EIGHT.ToString(), 8);
            cardValues.Add(CardValue.NINE.ToString(), 9);
            cardValues.Add(CardValue.TEN.ToString(), 10);
            cardValues.Add(CardValue.QUEEN.ToString(), 10);
            cardValues.Add(CardValue.KING.ToString(), 10);
            cardValues.Add(CardValue.JACK.ToString(), 10);

        }
        public DeckOfCards()
        {
            deckOfCards = new List<Card>();
            cardValues = new Dictionary<string, int>();
            CreateCardValues();

        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = deckOfCards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = deckOfCards[k];
                deckOfCards[k] = deckOfCards[n];
                deckOfCards[n] = value;
            }
        }

        public void CreateDeck()
        {
            
            for (int i = 0; i < NUMBER_OF_DECKS; i++)
            {
                foreach (string cardType in Enum.GetNames(typeof(CardType)))
                {
                    foreach (var card in cardValues)
                    {
                        deckOfCards.Add(new Card(cardType, card.Key, card.Value));
                    }
                }
            }
        }

        public List<Card> dealTwoCards()
        {
            Card cardOne = deckOfCards[0];
            Card cardTwo = deckOfCards[1];
            deckOfCards.RemoveAt(0);
            deckOfCards.RemoveAt(0);

            return new List<Card>() {cardOne, cardTwo };
        }

        public Card dealOneCards()
        {
            Card cardOne = deckOfCards[0];
            deckOfCards.RemoveAt(0);
            return cardOne;
        }
    }
}
