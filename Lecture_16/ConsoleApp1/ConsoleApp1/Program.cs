using ConsoleApp1.MyLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //string testStrOne = "testing";
            //char test = testStrOne[2];
            //Console.WriteLine(test);

            //string one = testStrOne.Remove(2);
            //Console.WriteLine(one);

            //string two = testStrOne.Replace('t', 'b');
            //Console.WriteLine(two);

            //Enemy enemyOne = new Enemy();
            //ConsoleApp1.MyLibs.Enemy enemyTwo = new MyLibs.Enemy("name");
            //enemyOne.Name = "firstName";
            //Console.WriteLine(enemyOne.Name);
            //enemyTwo.PrintName();

            File.WriteAllText("myFirstFile.txt", "Content of the file");
            string myFileText = File.ReadAllText("myFirstFile.txt");
            Console.WriteLine(myFileText);
            string[] myFileLines = File.ReadAllLines("myFirstFile.text");

               LinkedList<string> linkedlist = new LinkedList<string>();            
        }
    }
}
