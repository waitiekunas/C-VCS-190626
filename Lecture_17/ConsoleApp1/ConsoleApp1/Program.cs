using System;
using System.Collections.Generic;
using static ConsoleApp1.Class1;

namespace ConsoleApp1
{
    class Program
    {

        static void MyMultiply(int m1, int m2)
        {
            Console.WriteLine(m1*m2);
        }
        static void MySum(int m1, int m2)
        {
            Console.WriteLine(m1+m2);
        }
        static void Main(string[] args)
        {
            DoOperation doOperation = new DoOperation(MyMultiply);
            doOperation(1, 2);
            Console.WriteLine();
            doOperation += MySum;
            doOperation(1, 2);
            Console.WriteLine();
            doOperation -= MyMultiply;
            doOperation(1, 2);





            Console.WriteLine();
            Dictionary<int, string> manoZodynas = new Dictionary<int, string>();
            manoZodynas.Add(0, "nulis");
            manoZodynas.Add(1, "vienas");
            manoZodynas.Add(2, "du");
            manoZodynas.Add(3, "trys");

            Console.WriteLine(manoZodynas[0]);

            manoZodynas[0] = "nuuulis";
            Console.WriteLine(manoZodynas[0]);

            Console.WriteLine(manoZodynas.Count);

            manoZodynas.Remove(3);
            Console.WriteLine(manoZodynas.Count);
            Console.WriteLine(manoZodynas.ContainsValue("du"));
            Console.WriteLine(manoZodynas.ContainsKey(3));
            Console.WriteLine(manoZodynas.TryGetValue(0,out string value)) ;
            Console.WriteLine(value);
            foreach (KeyValuePair<int,string> keyValuePair in manoZodynas)
            {
                Console.WriteLine(keyValuePair.Value);
            }

            SortedDictionary<int, string> sortedDic = new SortedDictionary<int, string>();
            sortedDic.Add(1, "d");
            sortedDic.Add(3, "c");
            sortedDic.Add(0, "b");
            sortedDic.Add(2, "a");
            Console.WriteLine(sortedDic[2]);
            foreach (KeyValuePair<int, string> keyValuePair1 in sortedDic)
            {
                Console.WriteLine(keyValuePair1.Value);
            }

            LinkedList<string> linked = new LinkedList<string>();
            linked.AddFirst("First");
            linked.AddLast("Last");
            LinkedListNode<string> last = linked.Last;
            linked.AddBefore(last, "Mid");
            LinkedListNode<string> mid = linked.Find("Mid");
            linked.AddAfter(mid, "OneBeforeLast");
            Console.WriteLine(linked.Contains("Mid"));
            string[] arr = new string[4];
            linked.CopyTo(arr, 0);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            foreach (string item in linked)
            {
                Console.WriteLine(item);
            }



        }
    }
}
