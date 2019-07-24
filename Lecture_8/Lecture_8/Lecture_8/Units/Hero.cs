using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units
{
    class Hero : Unit
    {

        public Hero(int y, int x, string name) : base(y,x,name)
        {
         
        }

        public void MoveLeft()
        {
            X--;
            Console.WriteLine("Moving left");
            Console.WriteLine(X + " " + " " + Y);
        }

        public void MoveRight()
        {
            X++;
            Console.WriteLine("Moving right");
            Console.WriteLine(X + " " + " " + Y);

        }

    }
}
