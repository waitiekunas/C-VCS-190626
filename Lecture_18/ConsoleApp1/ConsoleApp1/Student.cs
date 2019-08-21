using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : IComparable<Student>
    {
        public int Id
        {
            get;
        }
        public string Name { get;}
        public int Age { get; }
        public int AverageMark { get; }
        public bool IsGettingTuition { get; }

        public Student(int id, string name, int age, int averageMark, bool isGettingTuition)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.AverageMark = averageMark;
            this.IsGettingTuition = isGettingTuition;
        }

        public void printInfo()
        {
            Console.WriteLine($"id:{Id}, name:{Name}, age: {Age}, averageMark: {AverageMark}, isGettingTuition: {IsGettingTuition}");
        }

        public int CompareTo(Student obj)
        {
            return Age - obj.Age;
        }
    }
}
