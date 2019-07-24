using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units
{
    class Enemy : Unit 
    {
        private static List<int> ids = new List<int>() {0};
        private int id;
        
        public Enemy(int y, int x, string name) : base(y,x,name)
        {
            id = GenerateId(ids);
        }

        private int GenerateId(List<int> ids)
        {
            ids.Add(ids[ids.Count - 1]+1);
            return ids[ids.Count - 1];
        }


        public void MoveDown()
        {
            Y--;
            Console.WriteLine("Moving down");
            Console.WriteLine( X+ " " + " "+ Y);
        }

        public void MoveUp()
        {
            Y++;
            Console.WriteLine("Moving up");
            Console.WriteLine(X + " " + " " + Y);

        }

        public int GetId ()
        {
            return id;
        }
    }
}
