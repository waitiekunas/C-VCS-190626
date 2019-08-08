using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TestCompany
{
    sealed class Worker : Human
    {
        private int _salary;
        public int GetSalary()
        {
            return _salary;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Salary: {_salary}, Name: {_name}");
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }

        public Worker(string name, int salary) : base(name)
        {
            _salary = salary;
        }
    }
}
