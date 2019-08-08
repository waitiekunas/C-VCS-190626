using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FourthClass
    {
        private int width;
        private int depth;

        private FourthClass() { }

        private FourthClass(int newWidth, int newDepth)
        {
            width = newWidth;
            depth = newDepth;
        }

        public static FourthClass CreateFourthClass (int newWidth, int newDepth)
        {
            return new FourthClass(newWidth, newDepth);
        }
    }
}
