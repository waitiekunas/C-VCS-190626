using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CoffeeMaker
{
    class Coffee
    {
        string type;
        int sugarSpoons;
        public Coffee(string coffeeType, int sugar)
        {
            type = coffeeType;
            sugarSpoons = sugar;
        }
        public string GetCoffeeType()
        {
            return type;
        }
    }
}
