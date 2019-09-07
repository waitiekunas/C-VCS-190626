using BlackJack.Actions;
using BlackJack.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameElements
{
    class Dealer : Person
    {

        private readonly int MAX_HAND_VALUE = 11;
        public Dealer(string name, string surname, int age, DeckOfCards deckOfCards)
        {
            deck = deckOfCards;
            title = "dealer";
            this.name = name;
            this.surname = surname;
            this.age = age;
            cardPairs = new Dictionary<List<Card>, int>();
        }
        public override void GetCardsPairInfo(List<Card> list)
        {
            Console.WriteLine("Your cards are:");
            foreach (Card card in list)
            {
                card.CardInfo();
            }
        }
        public int Play()
        {
            try
            {
                foreach (var item in cardPairs)
                {
                    if (item.Key[0].GetCardValue() == 10 && item.Key[0].GetCardName() == item.Key[1].GetCardName())
                    {
                        Split(item);
                    }
                    if (item.Value < 17)
                    {
                        Hit(item);
                    }
                }
            }
            catch (Exception)
            {

                Play();
            }
            
           
            return 0;
        }


        protected override void SetScoreForAce(List<Card> list)
        {
            if (list[0].GetCardName() != CardValue.ACE.ToString() && list[0].GetCardName() != CardValue.ACE.ToString())
            {
                foreach (var card in list)
                {
                    if (card.GetCardName() == CardValue.ACE.ToString())
                    {
                        if (list[0].GetCardValue() + list[1].GetCardValue() < 11)
                            card.SetAceValue(11);
                    }
                }
            }

        }

        public void DealerInfo()
        {
            Console.WriteLine("Dealer info");
            foreach (var item in cardPairs)
            {
                foreach (var card in item.Key)
                {
                    card.CardInfo();
                }
                Console.WriteLine($"Score: {item.Value}");
            }
        }

        public override void Hit(KeyValuePair<List<Card>, int> keyValuePair)
        {
            List<Card> keyValuePairTemp = keyValuePair.Key;
            keyValuePairTemp.Add(deck.dealOneCards());
            cardPairs.Remove(keyValuePair.Key);
            ReceivePair(keyValuePairTemp);
        }

        public void Split(KeyValuePair<List<Card>, int> keyValuePair)
        {
            cardPairs.Remove(keyValuePair.Key);
            ReceivePair(new List<Card>() {keyValuePair.Key[0],deck.dealOneCards()});
            ReceivePair(new List<Card>() { keyValuePair.Key[1], deck.dealOneCards()});
        }

       
    }
}
