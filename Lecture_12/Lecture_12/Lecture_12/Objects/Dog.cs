using Lecture_12.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12.Objects
{
    class Dog : IPrintable, IMovable, IRenderable
    {
        public void Move()
        {
            Console.WriteLine("Dog Moves");
        }

        public void Print()
        {
            Console.WriteLine("Dog");
        }

        public void Render()
        {
            Console.WriteLine("Dog rendered");
        }
    }
}
