using Lecture_12.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12.Objects
{
    class Ghost : IPrintable, ISpeaks, IMovable, IRenderable
    {
        public void Move()
        {
            Console.WriteLine("Ghost moves");
        }

        public void Print()
        {
            Console.WriteLine("Ghost");
        }

        public void Render()
        {
            Console.WriteLine("Ghost rendered");
        }

        public void Speak()
        {
            Console.WriteLine("Ghost speaks");
        }
    }
}
