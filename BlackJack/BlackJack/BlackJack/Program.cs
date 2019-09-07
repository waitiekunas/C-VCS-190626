using BlackJack.Controller;
using BlackJack.GameElements;
using BlackJack.Resources;
using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gameController = new GameController();
            gameController.LestPlay();
        }
    }
}
