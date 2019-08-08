using Lecture_12.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12.Objects
{
    class Hero : IPrintable, IMovable, ISpeaks, IRenderable
    {
        private readonly string read = "a";
        private readonly string readB;

        public Hero() { }
        public Hero(string b)
        {
            readB = b;
        }
       
        public static void aa()
        {
            Console.WriteLine("aa");
        }
        public void Move()
        {
            Console.WriteLine("Hero moves");
        }

        public void Print()
        {
            Console.WriteLine("Hero");
        }

        public void Render()
        {
            Console.WriteLine("Hero rendered");
        }

        public void Speak()
        {
            Console.WriteLine("Hero speaks");
        }
    }
}
