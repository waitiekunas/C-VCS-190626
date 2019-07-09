using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void PrintEveryThirdNumber(int number)
        {
            for(int i = 1; i<=number; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static void SquareRootRange()
        {
            Console.WriteLine("please enter range");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("Invalid range");
                return;
            }
            int counter = 1;
            for(int i = first+1; i<second; i++)
            {
                int root = i * i;
                Console.WriteLine($"Cycle: {counter}; root value: {root}");
                Console.WriteLine();
                counter++;
            }
        }
        public static void SumOfThousand()
        {
            int sum = 0;
            for(int i=0; i<1000; i++)
            {
                if(i>0 && i % 3==0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        public static void WhileChoises()
        {
            Console.WriteLine("1 Coffee");
            Console.WriteLine("2 Tea");
            Console.WriteLine("3 Soda");
            int number=0;
            while(number<1 || number > 3)
            {
                Console.WriteLine("Please make selection");
                number = Convert.ToInt32(Console.ReadLine());
                if(number < 1 || number > 3)
                {
                    Console.WriteLine("Invalid selection");
                }
                
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Coffee");
                    break;
                case 2:
                    Console.WriteLine("Tea");
                    break;
                case 3:
                    Console.WriteLine("Soda");
                    break;
                default:
                    break;
            }
        }
        private const int TOTAL_SEATS = 8;
        private const int TOTAL_SEATS_BY_THE_WINDOW = 4;
        private const String YES = "y";
        private const String NO = "n";

        public static void SeatPicker()
        {
            int totalSeats = 0;
            int seatsByTheWindow = 0;

            do
            {
                Console.WriteLine("If you want to sit by the window please enter 'y', else please enter 'n'");
                String choice = Console.ReadLine();
                switch (choice)
                {
                    case String s when (s == YES || s == "yes" || s == "1"):
                        totalSeats++;
                        seatsByTheWindow++;
                        break;
                    case String n when (n==NO || n== "no" || n=="0"):
                        totalSeats++;
                        break;
                    default:
                        Console.WriteLine("Incorrect selection");
                        break;
                }
            } while (totalSeats<TOTAL_SEATS && seatsByTheWindow<TOTAL_SEATS_BY_THE_WINDOW);
            Console.WriteLine("End");
        }
        public static void Cycle()
        {
            int sum = 0;
            for(int i=0; i<=1000; i++)
            {
                if (i > 123) { break; }
                if (i % 5 == 0) { continue; }

                sum += i;
            }
            Console.WriteLine(sum);
        }
        public static void Fibonachi()
        {
            Console.WriteLine("how many fibonachi steps to show?");
            int steps = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int sum = 0;
            for(int i=0; i<steps; i++)
            {
                sum = first + second;
                Console.WriteLine(sum);
                first = second;
                second = sum;
            }
        }

        public static void RandomNumber()
        {
            bool cont = true;
            int guesCounter = 0;

            while (cont)
            {
                int number = new Random().Next(0, 100);
                Console.WriteLine("Guess the number");
                int guess = Convert.ToInt32(Console.ReadLine());
                guesCounter++;
                if (number == guess)
                {
                    Console.WriteLine($"Congratz, you won! It took you {guesCounter} times");
                    cont = false;
                    break;
                }
                if (guess > number)
                {
                    Console.WriteLine("Your guess was too high");
                } else
                {
                    Console.WriteLine("Your guess was too low");
                }

            }
        }
        public static void Calculator()
        {
            String end="";
            do
            {
                Console.WriteLine("Please enter number");
                int firstNumber = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Please enter action");
                char keyPress = Console.ReadKey(true).KeyChar;

                if (keyPress == 27)
                {
                    end = "0";
                    continue;
                }

                switch (keyPress)
                {
                    case '+':
                        break;
                    case '-':
                        break;
                    case '/':
                        break;
                    case '%':
                        break;
                    case '*':
                        break;
                    default:
                        Console.WriteLine("Incorrect action");
                        continue;
                }

                Console.WriteLine("Please enter number");
                int thirdNumber = Convert.ToInt32(Console.ReadLine());
                if(keyPress=='/' && firstNumber==0 || thirdNumber == 0)
                {
                    Console.WriteLine("Division from 0 is not allowed");
                    continue;
                }
                Console.WriteLine($"your selected expression is {firstNumber} {keyPress} {thirdNumber}. Your answer is:");

                switch (keyPress)
                {
                    case '+':
                        Console.WriteLine(firstNumber+thirdNumber);
                        break;
                    case '-':
                        Console.WriteLine(firstNumber-thirdNumber);
                        break;
                    case '/':
                        Console.WriteLine(firstNumber/thirdNumber);
                        break;
                    case '%':
                        Console.WriteLine(firstNumber%thirdNumber);
                        break;
                    case '*':
                        Console.WriteLine(firstNumber*thirdNumber);
                        break;
                    default:
                        
                        break;
                }


                Console.WriteLine("if you want to terminate, pres 0 or n");
                end = Console.ReadLine();

            } while (end!="0"&&end!="n");
        }



        static void Main(string[] args)
        {
            //PrintEveryThirdNumber(20);
            //SquareRootRange();
            //SumOfThousand();
            //WhileChoises();
            //SeatPicker();
            //Cycle();
            //Fibonachi();
            //RandomNumber();
            Calculator();
        }
    }
}
