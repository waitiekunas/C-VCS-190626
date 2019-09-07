using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.MyLibrary
{
    class Enemy : IEnemy
    {
        private string _name;
        public void DoStuff()
        {
            Console.WriteLine("Doing IEnemy stuff");
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
