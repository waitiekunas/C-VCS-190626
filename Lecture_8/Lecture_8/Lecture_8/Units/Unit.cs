using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_8.Units
{
    class Unit
    {
        protected int Y;
        protected int X;
        private string Name;

        public Unit(int y, int x, string name)
        {
            Y = y;
            X = x;
            this.Name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"name: {Name}; Location: {X} {Y}");
        }

        protected string GetName()
        {
            return Name;
        }
    }
}
