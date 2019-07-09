using System;

namespace ConsoleApp1
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello World!");
            SaySomething();
        }
        static void SaySomething()
        {
            Console.WriteLine("Saying something");
        }
        static void SayBye()
        {
            Console.WriteLine("Bye!");
        }
        static void Mathematics()
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Sum(firstNumber, secondNumber);
            Substract(firstNumber, secondNumber);
            Division(firstNumber, secondNumber);
            Multiplication(firstNumber, secondNumber);
        }
        static void Sum(int first = 1, int second = 1)
        {
            Console.WriteLine($"Sum: {first+second}");
        }
        static void Substract(int first = 2, int second = 1)
        {
            Console.WriteLine($"Substraction: {first-second}");
        }
        static void Division(int first = 1, int second = 1)
        {
            Console.WriteLine($"Division: {first/second}");
        }
        static void Multiplication(int first = 1, int second = 1)
        {
            Console.WriteLine($"Multiplication: {first*second}");
        }
        static double KMICalculator(int weight = 70, double height = 1.80) => weight / (height * height);
        static string GetKMIResult(double KMI=26)
        {
            switch (KMI)
            {
                case double KM  when KM < 15:
                    return "badaujantis zmogus";
                case double KM when KM < 18.5:
                    return "liesas zmogus";
                case double KM when KM < 25 && KM > 18.5:
                    return "normalaus zmogaus svoris";
                case double KM when KM < 30 && KM > 25:
                    return "virssvorio turintis zmogus";
                case double KM when KM < 40 && KM > 30:
                    return "nutukes zmogus";
                case double KM when KM > 40:
                    return "ligotai nutukes zmogus";
                default:
                    break;
            }
            return "";
        }       
        static void IncreaseNormal (int number)
        {
            number++;
        }
        static void IncreaseRef(ref int number)
        {
            number++;
        }
        static void IncreaseOut(out int number)
        {
            number = 7;
            number++;
        }
        static double Max(int first, int second, int third)
        {
            if(first > second && first > third)
            {
                return first;
            } else if (second > first && second > third)
            {
                return second;
            } else if (third > first && third > second)
            {
                return third;
            }
            return first == second ? first : first == third ? first : second == third ? second : 0;
        }
        static bool InRange(int first, int second, int third) => first > second && first < third ? true : first < second && first > third ? true : false;
        static bool IsPrimal(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int D20()
        {
            Random random = new Random();
            return random.Next(1,20);
        }
        static int GetNumber(int min, int max)
        {
            Console.WriteLine($"Please enter a number between {min} and {max}");
            int entry = Convert.ToInt32(Console.ReadLine());
            if (entry <= min || entry >= max)
            {
                Console.WriteLine("not in range");
                entry = GetNumber(min, max);
            }
            return entry;
        }
        static void Main(string[] args)
        {
            //SayHello();
            //SaySomething();
            //SayBye();
            //Mathematics();
            //Sum();
            //Substract();
            //Division();
            //Multiplication();
            //Console.WriteLine(GetKMIResult(KMICalculator()));
            //int num = 5;
            //Console.WriteLine($"start {num}");
            //IncreaseNormal(num);
            //Console.WriteLine($"normal {num}");
            //IncreaseRef(ref num);
            //Console.WriteLine($"ref {num}");
            //IncreaseOut(out num);
            //Console.WriteLine($"out {num}");
            //Console.WriteLine(IsPrimal(6));
            Console.WriteLine(GetNumber(2,4));

        }
    }
}
