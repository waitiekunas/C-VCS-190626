using Lecture_12.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12.Objects
{
    class House : IPrintable, IRenderable
    {
        public void Print()
        {
            Console.WriteLine("House");
        }

        public void Render()
        {
            Console.WriteLine("House render");
        }
    }
}
