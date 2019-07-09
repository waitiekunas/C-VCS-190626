using System;

namespace Lecture_2
{
    class Program
    {
        public double Plotas(int num) => num * num * Math.PI;
        public double Spindulys(int num) => num * 2 * Math.PI;

        public void Speed()
        {
            Console.WriteLine("Please enter distance in meters and time in seconds");
            double distance = Convert.ToDouble(Console.ReadLine());
            double time = Convert.ToDouble(Console.ReadLine());

            distance = distance / 1000;
            time = time / 60;
            double speed = distance / time;

            Console.WriteLine($"Your speed is {speed}");
        }

        public void MultiplyThreeNumbers()
        {
            Console.WriteLine("Please enter three numers");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double third = Convert.ToDouble(Console.ReadLine());

            double multiplication = first * second * third;
            Console.WriteLine($"The result of multiplication is {multiplication}");
        }

        public void FourActions()
        {
            Console.WriteLine("Please enter two numbers");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());

            double sum = first + second;
            double substraction = first - second;
            double multiplication = first * second;
            double division = first / second;

            Console.WriteLine($"sum: {sum}, substraction: {substraction}, multiplication: {multiplication}, division: {division}");
        }

        public void FourNumbers()
        {
            Console.WriteLine("Please enter four numbers");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double third = Convert.ToDouble(Console.ReadLine());
            double fourth = Convert.ToDouble(Console.ReadLine());

            double median = (first + second + third + fourth) / 4;
            Console.WriteLine($"First {first}, second {second}, third {third}, fourth {fourth}, median {median}");

        }

        public void FToC()
        {
            Console.WriteLine("Please enter temperature in Fahrenheit");
            double fah = Convert.ToDouble(Console.ReadLine());

            double cel = (fah - 32) / 1.8;

            Console.WriteLine($"Temperature in Celcius is {cel}");
        }

        const int WORK_HOURS_PER_DAY = 8;
        public void Bakery()
        {
            Console.WriteLine("Please enter bread per hour");
            double breadPerHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter No. of workers in a bakery");
            double workersInBakery = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bread production cost");
            double breadProductionCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter bread selling price");
            double breadSellingPrice = Convert.ToDouble(Console.ReadLine());

            double breadsPerDay = HowManyBreadPerDay(breadPerHour, workersInBakery);
            double totalCost = TotalProductionCost(breadsPerDay, breadProductionCost);
            double totalIncome = TotalIncome(breadsPerDay, breadSellingPrice);
            double profit = Profit(totalCost, totalIncome);
            Console.WriteLine($"You can produce {breadsPerDay} breads per day. \n Breads per day: {breadsPerDay}. \n Total cost: {totalCost}. \n Total income: {totalIncome}. \n Total profit: {profit}");

        }

        private double HowManyBreadPerDay(double breadPerHour, double workersNo) => breadPerHour * WORK_HOURS_PER_DAY * workersNo;
        private double TotalProductionCost(double breadPerDay, double cost) => breadPerDay * cost;
        private double TotalIncome(double breadPerDay, double sellingPrice) => breadPerDay * sellingPrice;
        private double Profit(double cost, double income) => income-cost;

        public void Grade()
        {
            Console.WriteLine("Please enter your grade");
            double grade = Convert.ToDouble(Console.ReadLine());
            if (grade == 10)
            {
                Console.WriteLine("Great");
            } else if (grade == 9 || grade == 8)
            {
                Console.WriteLine("Very good");
            } else if (grade==7 || grade == 6)
            {
                Console.WriteLine("Good");
            } else if (grade == 5)
            {
                Console.WriteLine("Mediocre");
            } else if (grade == 4)
            {
                Console.WriteLine("At least positive");
            } else if (grade <= 3 && grade >= 1)
            {
                Console.WriteLine("Very bad");
            } else
            {
                Console.WriteLine("Incorrect value");
            }
        }


        public void Choises()
        {
            Console.WriteLine("Enter any number from 1 to 5");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Print("Soda");
                    break;
                case 2:
                    Print("Coffee");
                    break;
                case 3:
                    Print("Tea");
                    break;
                case 4:
                    Print("Water");
                    break;
                case 5:
                    Print("Beer");
                    break;
                default:
                    Console.WriteLine("Incorrect value");
                    break;
            }
        }

        private void Print(string beverage) => Console.WriteLine($"You have selected {beverage}");

        public void threeNumbers()
        {
            Console.WriteLine("Please enter three numbers");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double third = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"First condition is {first > second && first < 100}");

            Console.WriteLine($"First condition is {second > 0 && second > first}");

            Console.WriteLine($"First condition is {first > second && first > third || first > 0}");

            Console.WriteLine($"First condition is {third >= 5 && third <= 10 || third > first || third > second}");


        }

        public static void threeNumbersAgain()
        {
            Console.WriteLine("Please enter three numbers");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double third = Convert.ToDouble(Console.ReadLine());

            switch (first)
            {
                case 1:
                    Console.WriteLine(first+second+third);
                    break;
                case 2:
                    Console.WriteLine(first-third);
                    break;
                case 3:
                    Console.WriteLine(second*third);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite apskritimo spinduli");
            //int number = Convert.ToInt32(Console.ReadLine());

            Program program = new Program();

            //Console.WriteLine("Plotas: " + program.Plotas(number));
            //Console.WriteLine("Spindulys: " + program.Spindulys(number));

            //program.Speed();
            //program.MultiplyThreeNumbers();
            //program.FourActions();
            //program.FourNumbers();
            //program.FToC();
            //program.Bakery();
            //program.Choises();
            //program.Grade();
            //program.threeNumbers();
            threeNumbersAgain();
        }
    }
}
