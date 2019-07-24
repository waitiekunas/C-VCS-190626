using Lecture_8.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units
{
    class GameController
    {
        public void StartGame()
        {
            GameScreen myGame = new GameScreen(100, 100);
            myGame.SetHero(new Hero(2, 3, "Jonas"));

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(random.Next(0, 100), random.Next(0, 100), $"Virgis{i}"));

            }
            myGame.Render();
            myGame.MoveHeroLeft();
            myGame.MoveAllEnemiesDown();
            myGame.MoveEnemyDown(2);
            myGame.Render();
            bool needToRender = true;
            do
            {
                Console.Clear();
                myGame.Render();
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:
                        needToRender = false;
                        break;
                    case ConsoleKey.LeftArrow:
                        myGame.MoveHeroLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        myGame.MoveHeroRight();
                        break;
                    default:
                        break;
                }
                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }
    }
}
