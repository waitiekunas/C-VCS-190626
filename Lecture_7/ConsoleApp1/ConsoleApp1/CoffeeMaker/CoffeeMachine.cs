using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CoffeeMaker
{
    class CoffeeMachine
    {
        string model;
        List<Coffee> coffeeSelections;
        List<Cup> coffeeCupsSizes;

        public CoffeeMachine(string name)
        {
            coffeeCupsSizes = new List<Cup>();
            coffeeSelections = new List<Coffee>();
            model = name;
        }

        public void AddCoffeeType(string type, int sugar)
        {
            coffeeSelections.Add(new Coffee(type, sugar));
        }
        public void AddCup(string size)
        {
            coffeeCupsSizes.Add(new Cup(size));
        }
        public CoffeeCup MakeCoffee()
        {
            Cup cup=null;
            Coffee coffee=null;
            Console.WriteLine("What size of cup do you want?");
            Console.WriteLine();
            foreach (var item in coffeeCupsSizes)
            {
                Console.Write(item.GetSize() + " ;");
            }
            string sizeSelection = Console.ReadLine();
            foreach ( var item in coffeeCupsSizes)
            {
                if (sizeSelection.ToUpper() == item.GetSize().ToUpper())
                {
                    Console.WriteLine($"you selections is {sizeSelection.ToUpper()}");
                    cup = item;
                    break;
                }
            }
            if(cup == null)
            {
                Console.WriteLine("Invalid selection");
                return null;
            }

            Console.WriteLine("Make you coffee selection");
            foreach (var item in coffeeSelections)
            {
                Console.Write(item.GetCoffeeType() + " ;");
            }
            string coffeeSelection = Console.ReadLine();

            foreach (var item in coffeeSelections)
            {
                if (coffeeSelection.ToUpper() == item.GetCoffeeType().ToUpper())
                {
                    Console.WriteLine($"your selection is {coffeeSelection.ToUpper()}");
                    coffee = item;
                    break;
                }
            }
            if (coffee == null)
            {
                Console.WriteLine("Invalid selection");
                return null;
            }

            Console.WriteLine("Please take your coffee!");
            return new CoffeeCup(cup, coffee);

        }

    }
}
