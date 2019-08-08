using Lecture_12.Interfaces;
using Lecture_12.Objects;
using System;
using System.Collections.Generic;

namespace Lecture_12
{
    class Program
    {
        public static void CheckRender (IRenderable renderable)
        {
            renderable.Render();
        }
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Dog dog = new Dog();
            Ghost ghost = new Ghost();
            House house = new House();
            Sun sun = new Sun();
            hero.Print();
            dog.Print();
            ghost.Print();
            house.Print();
            sun.Print();

            List<IPrintable> printables = new List<IPrintable>();
            printables.Add(hero);
            printables.Add(dog);
            printables.Add(ghost);
            printables.Add(house);
            printables.Add(sun);

            IRenderable[] renderables = new IRenderable[4];
            renderables[0] = hero;
            renderables[1] = dog;
            renderables[2] = ghost;
            renderables[3] = house;

            Console.WriteLine("printables:");
            foreach (var printable in printables)
            {
                printable.Print();
            }
            Console.WriteLine();
            Console.WriteLine("Renderables:");
            foreach (var rendered in renderables)
            {
                rendered.Render();
            }

        }
    }
}
