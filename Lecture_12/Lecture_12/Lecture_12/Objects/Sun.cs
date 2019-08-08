using Lecture_12.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12.Objects
{
    class Sun : IPrintable, IGlows
    {
        public void Glow()
        {
            Console.WriteLine("Sun Glows");
        }

        public void Print()
        {
            Console.WriteLine("Sun");
        }
    }
}
