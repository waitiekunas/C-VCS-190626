using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
            {
                new Student(1,"first", 20, 8, true),
                new Student(2,"second", 21, 9, true),
                new Student(3,"third", 49, 4, false),
                new Student(4, "fourth", 31, 7, false)
            };

            var chaining = from s in students
                           where s.Name.Count() > 5
                           select new { s.Id, s.Name, Status = s.AverageMark < 5 ? "Bad" : s.AverageMark > 8 ? "Good" : "Ok" }
                            into toBeGrouped
                           group toBeGrouped by toBeGrouped.Status;
                          

            var newListTwo = from s in students
                             where s.IsGettingTuition == true
                             select s
                                into gS
                             select new { gS.Name, GoodStudent = gS.AverageMark > 8  };

            foreach (var item in newListTwo)
            {
                Console.WriteLine(item);
            }
                                

            var newList = from s in students
                          where s.Age > 20
                          select s
                            into overTwenty
                            orderby overTwenty.Name
                            select new { overTwenty.Id, overTwenty.Name };

            foreach (var item in newList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            var groupByDecade = students.GroupBy(s => s.Age/10);
            foreach (var item in groupByDecade)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    i.printInfo();
                }
            }
            Console.WriteLine();


            var groupByTuition = students.GroupBy(s => s.IsGettingTuition);
            foreach (var item in groupByTuition)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    i.printInfo();
                }
            }
            Console.WriteLine();

            var groupByAge = students.GroupBy(s => s.Age==21);

            foreach (var item in groupByAge)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    i.printInfo();
                }
            }
            Console.WriteLine();

            var ageAndMark = students.OrderByDescending(s => s.Age).ThenByDescending(s => s.AverageMark);
            foreach (var item in ageAndMark)
            {
                Console.WriteLine(item.AverageMark+"  "+item.Age);
            }
            Console.WriteLine();

            var age = students.OrderByDescending(s => s.Age).Reverse();

            foreach (var item in age)
            {
                Console.WriteLine(item.Age);
            }
            Console.WriteLine();

            var averageMarkSecond = from s in students
                                    orderby s.AverageMark descending
                                    select s;
            foreach (var item in averageMarkSecond)
            {
                Console.WriteLine(item.AverageMark);
            }
            Console.WriteLine();

            var averageMark = students.OrderByDescending(s => s.AverageMark);
            foreach (var item in averageMark)
            {
                Console.WriteLine(item.AverageMark);
            }
            Console.WriteLine();


            IList<int> secondList = new List<int>() { 5, 6, 7 };

            var test = secondList.Select(s => s * s);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var average = secondList.Average();
            Console.WriteLine(average);
            Console.WriteLine();

            var allSum = secondList.Sum();
            Console.WriteLine(allSum);
            Console.WriteLine();

            var allSquare = from e in secondList
                            select e * e;

            foreach (var item in allSquare)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            IList<int> list = new List<int>() { 1, 2,3,4,5,6,7,8,9,10 };

            var dividesFromEight = list.Any(s => s % 8 == 0);
            Console.WriteLine(dividesFromEight);
            Console.WriteLine();

            var allEven = list.All(s => s % 2 == 0);
            Console.WriteLine(allEven);

            Console.WriteLine();
            var oddNumbers = from s in list
                             where s % 2 != 0
                             select s;
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var dividesFromFive = list.Where(s => s % 5 == 0);

            foreach (var item in dividesFromFive)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var containsSeven = list.Contains(7);
            Console.WriteLine(containsSeven);
            Console.WriteLine();
        }
    }
}
