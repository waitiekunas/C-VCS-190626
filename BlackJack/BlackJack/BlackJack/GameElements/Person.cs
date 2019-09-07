using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.Actions;
using BlackJack.Resources;

namespace BlackJack.GameElements
{
    public abstract class Person : IGameActions
    {
        static public readonly int MAX_SCORE = 21;
        protected string name;
        protected string surname;
        protected string title;
        protected int age;
        protected DeckOfCards deck;

        public Dictionary<List<Card>, int> cardPairs { get; set; }
        protected int score;

        public virtual void GetCardsPairInfo(List<Card> cardPair)
        {
            if (title == "player")
            {
                foreach (Card card in cardPair)
                {
                    card.CardInfo();
                }
            }
        }

        public int CalculateScore(List<Card> list)
        {
            SetScoreForAce(list);
            int score = 0;
            foreach (var item in list)
            {
                score += item.GetCardValue();
            }

            return score;
        }

        protected virtual void SetScoreForAce(List<Card> list)
        {

            foreach (var card in list)
            {
                if (card.GetCardName() == CardValue.ACE.ToString() && list.Count < 3)
                {
                    GetCardsPairInfo(list);
                    int value = 0;
                    Console.WriteLine("You have ACE, would you like to set its value to 1 or 11?");
                    while (value == 0)
                    {
                        try
                        {
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value != 1 && value != 11)
                            {
                                Console.WriteLine("Invalid value, try again");
                                value = 0;
                            }
                            else
                            {
                                card.SetAceValue(value);
                                Console.Clear();
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Invalid value");
                        }
                    }
                }
            }


        }
        public string GetName()
        {
            return name;
        }
        public void ReceivePair(List<Card> pair)
        {
            cardPairs.Add(pair, CalculateScore(pair));
        }

        public virtual void Hit(KeyValuePair<List<Card>, int> keyValuePair)
        {
            Console.WriteLine("HIT");
        }

        public virtual void Split(List<Card> listCard)
        {
            Console.WriteLine("split");
        }

        public virtual void Hold()
        {
            Console.WriteLine("HOLD");
        }
        
    }
}
