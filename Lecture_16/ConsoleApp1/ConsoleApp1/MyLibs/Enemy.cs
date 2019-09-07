using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.MyLibs
{
    class Enemy:Unit
    {
        private readonly string _name;
        public override void DoStuff()
        {
            Console.WriteLine("Doing enemy stuff");
        }
        public Enemy(string name)
        {
            _name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
}
