using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strings = new List<string>();
            //strings.Add("ser");
            //strings.Insert(1, "antras");
            //strings.AddRange(new string[]{ "asdas", "asdasd", "asdfda"});
            //strings.InsertRange(2, new List<string>() { "aaaa", "sssss" });
            //strings.ForEach((x)=> {
            //    int i = x.Length;
            //    Console.WriteLine(x);
            //    Console.WriteLine(i);
            //});

            //strings.RemoveAll((x)=> {
            //    if (x.Length == 3)
            //    {
            //        return true;
            //    }
            //    return false;
            //});


            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(1, 100));
            }

            numbers.RemoveAll((x) => x > 80 ? true : false);

            numbers.ForEach((x) =>
            {
                if (x % 2 == 0)
                {
                    Console.Write(x+","+" ");
                }
            });
            Console.WriteLine();
            Console.WriteLine("Count number which are <20 "+numbers.FindAll((x) => x < 20 ? true : false).Count);

        }
    }
}
