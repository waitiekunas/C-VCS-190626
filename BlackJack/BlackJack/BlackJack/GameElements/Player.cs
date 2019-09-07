using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameElements
{
    public class Player:Person
    {
        private Wallet wallet;
        public int bet { get; set; }
        public Player(string name, string surname, int age, int money, DeckOfCards deckOfCards)
        {
            deck = deckOfCards;
            title = "player";
            this.name = name;
            this.surname = surname;
            this.age = age;
            wallet = new Wallet(money);
            cardPairs = new Dictionary<List<Card>, int>();
        }

        public Wallet GetWallet()
        {
            return wallet;
        }
        public override void Split(List<Card> listCard)
        {
            if (listCard[0].GetCardName() == listCard[1].GetCardName() && listCard[0].GetCardValue() == 10)
            {
                cardPairs.Remove(listCard);
                ReceivePair(new List<Card>() { listCard[0], deck.dealOneCards() });
                ReceivePair(new List<Card>() { listCard[1], deck.dealOneCards() });
                wallet.WithdrawMoney(bet);
            }
        }

        public void CheckWalllet(int ammount)
        {
            if (wallet.GetCurrentAmmount() < ammount)
            {

            }
        }
        public virtual void Hit(List<Card> listCard)
        {
            listCard.Add(deck.dealOneCards());
            cardPairs.Remove(listCard);
            ReceivePair(listCard);
        }
    }
}
