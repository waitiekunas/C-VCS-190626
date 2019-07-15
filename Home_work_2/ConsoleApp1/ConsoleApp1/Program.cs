using System;

namespace ConsoleApp1
{
    class Program
    {

        static int[] firstArray = new int[6];
        static int[] secondtArray = new int[6];
        static char[] numbers = new char[10]
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        static int findPerfectNumber(int[]firstArr, int[]secondArr, char[]numbersArr, Random random) {
            int number;
            do
            {
                number = random.Next(100000, 166666);
            } while (!CheckNumbers(Convert.ToString(number)) || 
            !CheckNumbers(Convert.ToString(number*2)) || 
            !CheckNumbers(Convert.ToString(number*3)) || 
            !CheckNumbers(Convert.ToString(number*4)) || 
            !CheckNumbers(Convert.ToString(number*5)) || 
            !CheckNumbers(Convert.ToString(number*6)));

            int answer=number;
            Console.WriteLine("Check number is" + number);
            string numberString = Convert.ToString(number);
           
            IntToArr(numberString, firstArr);
            answer = MultiplyNumber(number, firstArr, secondArr, numbersArr, random);

            return answer;
            
        }

        private static int MultiplyNumber (int numb, int[] firstArr, int[] secondArr, char[] numbersArr, Random random)
        {
            int number = numb;
            for (int i = 2; i < 7; i++)
            {
                int numberS = number * i;
                IntToArr(numberS.ToString(), secondArr);
                if (!CheckIfArrsHaveSameDigits(firstArr, secondArr) || !CheckTwoArrs(firstArr, secondArr) || !CheckNumbers(Convert.ToString(numberS)))
                {
                    number = findPerfectNumber(firstArr, secondArr, numbersArr, random);
                }
            }
            return number;
        }

        private static bool CheckIfArrsHaveSameDigits(int[] firstArr, int[] secondArr)
        {
            int counter = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int y = 0; y < secondArr.Length; y++)
                {
                    if (firstArr[i] == secondArr[y])
                    {
                        counter++;
                    }
                }
            }
            return counter == 6 ? true : false;
        }

        private static bool CheckTwoArrs(int[] firstArr, int[] secondArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    return false;
                }
            }
            return true;
        }
        private static void IntToArr(string numberString, int[] numberArr)
        {
            for (int i = 0; i < numberString.Length; i++)
            {
                numberArr[i] = Convert.ToInt32(Convert.ToString(numberString[i]));
            }
        }
        public static bool CheckNumbers(string numberString)
        {
            for (int i=0; i < numberString.Length; i++)
            {
                for (int y = i+1; y < numberString.Length; y++)
                {
                    if (numberString[i] == numberString[y])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("The magic number is: " + findPerfectNumber(firstArray, secondtArray, numbers, random));
        }
    }
}
