using ConsoleApp1.CoffeeMaker;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            CoffeeMachine jura = new CoffeeMachine("JURA");

            jura.AddCup("M");
            jura.AddCup("L");
            jura.AddCup("XL");

            jura.AddCoffeeType("BLACK", 2);
            jura.AddCoffeeType("LATTE", 2);
            jura.AddCoffeeType("MOCHA", 2);

            CoffeeCup coffeeCup1 = jura.MakeCoffee();


        }
    }
}
