using BlackJack.GameElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Controller
{
    class GameController
    {
        private readonly int STARTING_AMOUNT = 500;
        private int numberOfPlayers;
        private Dealer dealer;
        private List<Player> players;
        private DeckOfCards deckOfCards;


        private void GetNumberOfPlayers()
        {
            Console.WriteLine("Please enter the number of players");
            while (numberOfPlayers == 0)
            {
                try
                {
                    numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid format. Please try again");
                }
            }
        }
        private bool CheckAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are too young.");
                return true;
            }
            return false;
        }
        private int GetAgeOfPlayer(int i)
        {
            Console.WriteLine($"Please enter age of player number {i}");
            int age = 0;
            while (age == 0 || CheckAge(age))
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect format, please try again");
                }
            }
            return age;
        }

        private void CreatePlayers(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine($"Please enter name of player number {i + 1}");
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter surname of player number {i + 1}");
                string surname = Console.ReadLine();
                int age = GetAgeOfPlayer(i + 1);
                players.Add(new Player(name, surname, age, STARTING_AMOUNT, deckOfCards));
                Console.Clear();
            }
        }

        private void CreateGame(int numberOfPlayers)
        {
            CreatePlayers(numberOfPlayers);
        }

        private void CreateDeackOfCards()
        {
            deckOfCards = new DeckOfCards();
            deckOfCards.CreateDeck();
            deckOfCards.Shuffle();
        }

        private void Deal()
        {
            foreach (Player player in players)
            {
                player.ReceivePair(deckOfCards.dealTwoCards());
            }
            dealer.ReceivePair(deckOfCards.dealTwoCards());
        }
        private void DealCards()
        {
            Deal();
        }
        private void MakeABet(Player player)
        {
            Console.WriteLine("Make you bet");
            int bet = 0;
            while (bet==0)
            {
                try
                {
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet < 20)
                    {
                        Console.WriteLine("Incorrect ammount, min bet is 20 euros");
                        bet = 0;
                    }
                    if (bet > player.GetWallet().GetCurrentAmmount())
                    {
                        Console.WriteLine("You don't have needed ammount, bet less");
                    }
                    if (player.GetWallet().GetCurrentAmmount() < 20)
                    {
                        bet = 1;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid value");
                }
            }
            player.GetWallet().WithdrawMoney(bet);
            player.bet = bet;
        }
 
        private void PlayerTurnActions(Player player)
        {
            try
            {
                foreach (var item in player.cardPairs)
                {
                    player.GetCardsPairInfo(item.Key);
                    Console.WriteLine("what would you like to do?");
                    Console.WriteLine("for hit press 1, for split press 2, for hold any key");
                    string entry = Console.ReadLine();
                    switch (entry)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("hit");
                            player.Hit(item.Key);
                            PlayerTurnActions(player);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Selection split");
                            player.Split(item.Key);
                            PlayerTurnActions(player);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Selection hold");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
            
        }
        private void Play()
        {
            bool start = true;
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.GetName()} turn");
                MakeABet(player);
                Console.Clear();
            }
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.GetName()} turn");
                if (start)
                {
                    DealCards();
                    start=false;
                }
                PlayerTurnActions(player);
            }

            dealer.Play();
        }
   
        private int CalculateHighestDealerScore()
        {
            int score = 0;
            foreach (var item in dealer.cardPairs)
            {
                score = score < item.Value && item.Value<22 ? item.Value : score;
            }
            return score;
        }
        private void CalculateWinnings()
        {
            int dealerScore = CalculateHighestDealerScore();
            foreach  (Player player in players)
            {
                foreach (var item in player.cardPairs)
                {
                    if (dealerScore < item.Value && item.Value < 22)
                    {
                        player.GetWallet().ReceiveMoney(player.bet * 2);
                    }
                    ListEndScores(player);
                }
            }
        }

        private void ListEndScores(Player player)
        {
            Console.WriteLine($"{player.GetName()} has {player.GetWallet().GetCurrentAmmount()}");
            ListPairAndScores(player);
        }
        private void ListPairAndScores(Player player)
        {
            Console.WriteLine("Hands values were following:");
            foreach (var item in player.cardPairs)
            {
                player.GetCardsPairInfo(item.Key);
                Console.WriteLine($"Score: {item.Value}");
                Console.WriteLine();
            }
        }
        private void DetermineWinner()
        {
            
            CalculateWinnings();
            dealer.DealerInfo();

        }

        public GameController()
        {
            CreateDeackOfCards();
            dealer = new Dealer("Jack", "Black", 55, deckOfCards);
            players = new List<Player>();
        }

        public void LestPlay()
        {
            Console.WriteLine("Let's start the BlackJack game!");
            GetNumberOfPlayers();
            CreateGame(numberOfPlayers);
            Console.Clear();
            Console.WriteLine($"Starting wallet is {STARTING_AMOUNT} euros");
            Console.WriteLine("Cards are being dealt...");
            Play();
            DetermineWinner();
        }

    }
}
