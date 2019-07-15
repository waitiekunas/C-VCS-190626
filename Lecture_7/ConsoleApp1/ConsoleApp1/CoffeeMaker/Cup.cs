using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CoffeeMaker
{
    class Cup
    {
        string size;

        public Cup(string cupSize)
        {
            size = cupSize;
        }
       public string GetSize()
        {
            return size;
        }
    }
}
