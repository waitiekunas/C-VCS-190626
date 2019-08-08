using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        public static void changeValue(Class1 xx)
        {
            xx.name = "new value";
            xx.listOfInts.Add(1234);
            Console.WriteLine("inside func");
            Console.WriteLine();
            xx.printData();
            Console.WriteLine();

        }
        public static void changeValue(Structure xx)
        {
            xx.name = "new value";
            xx.listOfInts.Add(123);
            Console.WriteLine("inside func");
            Console.WriteLine();

            xx.printData();
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            //Class1 clas = new Class1();
            //Structure structure = new Structure();
            //clas.listOfInts = new List<int>();
            //clas.listOfInts.Add(11);
            //structure.listOfInts = new List<int>();
            //structure.listOfInts.Add(12);

            //clas.printData();
            //Console.WriteLine();

            //structure.printData();
            //Console.WriteLine();

            //clas.name = "simple change";
            //structure.name = "simple change";


            //clas.printData();
            //Console.WriteLine();

            //structure.printData();
            //Console.WriteLine();

            //changeValue(clas);
            //changeValue(structure);

            //clas.printData();
            //Console.WriteLine();

            //structure.printData();

            //switch (EN.ONE)
            //{
            //    case EN.ONE:
            //        Console.WriteLine("vienas");
            //        break;
            //    case EN.THRE:
            //        Console.WriteLine("trys");
            //        break;
            //    case EN.TWO:
            //        Console.WriteLine("du");
            //        break;
            //    default:
            //        break;
            //}


            //Enum. GetValues(EN);

            int[] masyvas = new int[3];
            try
            {
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch (IndexOutOfRangeException exception1)
            {
                Console.WriteLine("exception1");
                masyvas[masyvas.Length - 1] = 2;
                Console.WriteLine(masyvas[masyvas.Length - 1]);
            } catch(FormatException exception2)
            {
                Console.WriteLine("exception two");
            } finally
            {
                

            }
            Console.WriteLine("continued");

            
        }
    }
}
