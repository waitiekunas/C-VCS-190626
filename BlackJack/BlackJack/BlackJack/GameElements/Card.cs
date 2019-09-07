using BlackJack.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameElements
{
    public class Card
    {
        static public readonly int MAX_CARD_VALUE = 11;

        private string cardType;
        private string cardName;
        private int cardValue;
        

        public int GetCardValue()
        {
            return cardValue;
        }

        public void SetAceValue(int value)
        {
            if (cardName == CardValue.ACE.ToString() && (value==1 || value == 11))
            {
                cardValue = value;
            }
            else
            {
                Console.WriteLine($"Your card is not ACE or you have entered invalid value");
            }
        }

        public string GetCardName()
        {
            return cardName;
        }
        public void CardInfo()
        {
            Console.WriteLine($"{cardName} of {cardType}");
        }
        public Card(string cardType, string cardName, int cardValue)
        {
            this.cardType = cardType;
            this.cardName = cardName;
            this.cardValue = cardValue;
        }
    }
}
