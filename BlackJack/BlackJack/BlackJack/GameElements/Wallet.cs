using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.GameElements
{
    public class Wallet
    {
        private int amount;
        private void SubstractMoney(int amount)
        {
            this.amount -= amount;
        }
        public Wallet(int startAmount)
        {
            amount = startAmount;
        }
        public int WithdrawMoney(int amount)
        {
            if (this.amount > amount)
            {
                SubstractMoney(amount);
                return amount;
            }
            else
            {
                Console.WriteLine($"Not enough money, currently you have {this.amount}.");
                
                return 0;
            }
        }
        public void ReceiveMoney(int amount)
        {
            this.amount += amount;
        }
        public int GetCurrentAmmount()
        {
            return this.amount;
        }

       
    }
}
