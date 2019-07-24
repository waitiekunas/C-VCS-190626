using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units
{
    class GameScreen
    {
        int _width;
        int _height;
        Hero hero;
        List<Enemy> enemies;

        public GameScreen(int height, int width)
        {
            this._width = width;
            this._height = height;
            enemies = new List<Enemy>();
        }

        public void SetHero (Hero hero)
        {
            this.hero = hero;
        }

        public void MoveHeroRight()
        {
            hero.MoveRight();
        }
        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy); 
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in this.enemies)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById (int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if (id == enemy.GetId())
                {
                    return enemy;
                }
            }
            Console.WriteLine("No enemy with such id");
            return null;
        }
        public void Render()
        {
            Console.WriteLine("Hero:");
            hero.PrintInfo();
            Console.WriteLine("Enemies:");
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }

        public void MoveEnemyDown(int id)
        {
            Enemy enemy1;
            foreach (Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    enemy.MoveDown();
                }
            }
        }
    }
}
