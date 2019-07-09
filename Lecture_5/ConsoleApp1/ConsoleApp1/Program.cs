using System;

namespace ConsoleApp1
{
    class Program
    {

        private static string[] EntryOne()
        {
            Console.WriteLine("Please enter 5 string values");
            string[] data = new string[5];
            for(int i = 0; i<data.Length; i++)
            {
                data[i] = Console.ReadLine();
            }
            return data;
        }
        private static void ListEntries(string[] arr)
        {
            string result = "";
            foreach (var item in arr)
            {
                result = result + arr;
            }
            Console.WriteLine(result);
            ListEntriesBackwards(arr);  
        }

        private static void ListEntriesBackwards(string[] arr)
        {
            Console.WriteLine("Backwards");

            string back = "";
            for (int i = 0; i < arr.Length; i++)
            {
                back = back + arr[arr.Length - 1 - i];
            }
            Console.WriteLine(back);
        }


        private static string[] FindDublicates(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = i+1; y < arr.Length; y++)
                {
                    if (arr[i] == arr[y])
                    {
                        arr[i] = "!";
                    }
                }
                arr[i] = arr[i] + " ";
            }
            return arr;
        }

        private static string[] SortEntries(string[] arr)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] == "! " && arr[i+1] != "! ")
                    {
                        arr[i] = arr[i+1];
                        arr[i + 1] = "! ";
                    }
                }
            }
            Console.WriteLine("srt");
            return arr;
            
        }
        private static void SpoilArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }
        static int[] arrTest = new int[] { 1, 2, 3, 4, 5 };
    
        static void Main(string[] args)
        {
        //    string[] entries = EntryOne();
        //    ListEntries(entries);
        //    string[] entriesDub = FindDublicates(entries);

            //    ListEntries(entriesDub);
            //    ListEntries(SortEntries(entriesDub));
            foreach (var item in arrTest)
            {
                Console.WriteLine(item);
            }
            SpoilArray(arrTest);
            foreach (var item in arrTest)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
