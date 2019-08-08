using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ThirdClass
    {
        private int height = 199;

        public int GetHeight()
        {
            Console.WriteLine(height);
            return height;
        }

        private void SetHeight(int newHeight)
        {
            height = newHeight;
        }
        public int Height
        {
            get { return height; }
            set { SetHeight(value); }
        }
    }
}
