using System;
using System.Collections.Generic;

namespace Home_work_1
{

    class Program
    {

        static void NumberToText(int minRange = -999, int maxRange = 999)
        {
            Console.WriteLine($"Please enter number between {minRange} and {maxRange}");
            string numStr = Console.ReadLine();
            if (CheckIfNumber(numStr))
            {
                checkRange(numStr, minRange, maxRange);
            }
            else
            {
                Console.WriteLine("Incorrect entry");
            }
        }
        static private bool checkRange(string num, int minRange, int maxRange)
        {
            int numb = Convert.ToInt32(num);
            if (numb > minRange && numb < maxRange)
            {
                Console.WriteLine("In range");
                Console.WriteLine(numToText(numb));
                return true;
            }
            Console.WriteLine("Out of range");
            return false;
        }
        private static bool CheckIfNumber(string num)
        {
            string numbers = "0123456789";
            int i = 0;
            if (num[0] == '-')
            {
                i = 1;
            }
            for (int y = i; y < num.Length; y++)
            {
                if (!numbers.Contains(num[y]))
                {
                    return false;
                }
            }
            return true;
        }

        private static string numToText(int num)
        {
            string numberString = "";
            string numb = Convert.ToString(num);
            int number;
            int numberUnchanged;
            string ones = "";
            string tens = "";
            string hundred = "";

            if (numb.StartsWith('-'))
            {
                numberString = "minus ";
                numb = numb.Substring(1);
            }
            number = Convert.ToInt32(numb);

            hundred = HundredsToText(numb, number);
            tens = TensToText(numb, number);
            

            

            ones = OnesToText(number, numb);



            return numberString + hundred + tens + ones;
        }

        static private string OnesToText(int numb, string expression="" ) {
            string no = expression.Length > 1 ? Convert.ToString(expression[expression.Length - 1]) : expression;
            int nr = Convert.ToInt32(no);
            string ending = "";

            if (nr > 3 && Convert.ToString(expression[expression.Length - 2])=="1")
            {
                
                ending = "olika";
            }
            else if (nr < 4 && expression.Length>1 && Convert.ToString(expression[expression.Length - 2]) == "1")
            {
                nr = nr+10;
            }

            if (numb < 10)
            {
                nr = numb;
                ending = "";
            }
            
            Dictionary<int, string> firstDict = new Dictionary<int, string>()
            {
                {1,"vienas"},
                {2,"du"},
                {3,"trys"},
                {4,"keturi"},
                {5,"penki"},
                {6,"sesi"},
                {7,"septyni"},
                {8,"astuoni"},
                {9,"devyni"},
                {10,"desimt"},
                {11,"vienuolika"},
                {12,"dvylika"},
                {13,"trylika"}
        };
            if (nr == 0 && expression.Length==1)
            {
                return  "nulis";
            } 

            foreach (KeyValuePair<int, string> pair in firstDict)
            {

                if (pair.Key == nr)
                {
                    return pair.Value + ending;
                }

            }
            return "";
        }

        static private string TensToText(string textExpresion, int number)
        {
            if (textExpresion.Length < 2 || number < 20) { return ""; }
            string tens = Convert.ToString(textExpresion[textExpresion.Length - 2]);
            int ones = Convert.ToInt32(tens);
            Dictionary<int, string> tensDict = new Dictionary<int, string>()
            {
                {0,"" },
                {1,"" },
                {2," dvidesimt"},
                {3," trisdesimt"},
                {4," keturiasdesimt"},
                {5," penkiasdesimt"},
                {6," sesiasdesimt"},
                {7," septyniasdesimt"},
                {8," astuoniasdesimt"},
                {9," devyniasdesimt"}
               
        };
            foreach (KeyValuePair<int, string> pair in tensDict)
            {

                if (pair.Key == ones)
                {
                    tens = pair.Value;
                }

            }

            return tens;
        }
        private static string HundredsToText (string textExpresion, int number)
        {
            if (textExpresion.Length < 3) { return ""; }
            string hundreds = Convert.ToString(textExpresion[textExpresion.Length - 3]);
            if (Convert.ToInt32(hundreds)==1) { return "simtas "; }
            int ones = Convert.ToInt32(hundreds);
            if (OnesToText(ones, textExpresion) == "nulis") {
              return  "";
            } else { return OnesToText(ones, textExpresion) + " simtai "; }
        }

        static void Main(string[] args)
        {
            NumberToText();
        }
    }
}
