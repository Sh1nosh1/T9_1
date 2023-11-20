using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace T9_1
{
    internal class Program
    {
        //Task 1.3
        public static void Output(List<int> ints)
        {
            foreach(var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.4
        public static int Count(List<int> ints)
        {
            return ints.Count();
        }

        //Task 1.5

        public static int Index(List<int> ints)
        {
            return ints.IndexOf(25);
        }

        //Task 1.6
        public static void Rem(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.8
        public static bool Nal(List<int> ints)
        {
            return ints.Contains(25);
        }

        //Task 1.9
        public static void Insert(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.10
        public static void Sort(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 1.11
        public static void Sum(List<int> ints)
        {
            foreach (var element in ints)
            {
                Write($"{element};\t");
            }
        }

        //Task 2
        public static void Output_2(List<int> ints1)
        {
            foreach (var element in ints1)
            {
                Write($"{element};\t");
            }
            Console.WriteLine();
        }
        public static void Compare(List<int> ints1)
        {
            for(int i = 0; i < ints1.Count; i++)
            {
                if (Math.Abs(ints1[i]) % 2 != 0)
                {
                    ints1.RemoveAt(i);
                   i--;
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                //Task 1.1

                List<int> ints = new List<int>(); //Создали пустой список
                
                //Task 1.2

                ints.Add(1);
                ints.Add(10);
                ints.Add(25);
                ints.Add(17);
                ints.Add(10);

                //Task 1.3

                Output(ints);

                //Task 1.4

                WriteLine($"\n\nКоличество элементов: {Count(ints)}");

                //Task 1.5
         
                WriteLine($"\n\nИндекс 25: {Index(ints)}");

                //Task 1.6

                ints.RemoveAt(1);
                WriteLine();
                Rem(ints);

                //Task 1.8

                WriteLine($"\n\nИндекс 25: {Nal(ints)}"); 
                
                //Task 1.9

                ints.Insert(0, 500);
                WriteLine();
                Insert(ints);

                //Task 1.10

                ints.Sort();
                WriteLine();
                Sort(ints);

                //Task 1.11

                ints[0] += 3;
                WriteLine();
                Sum(ints);

                //Task 1.12

                Sum(ints);


                //Task 2

                Random rand = new Random();
                List<int> ints1 = new List<int>();

                for(int i = 0; i < 10; i++)
                {
                    ints1.Add(rand.Next(-100, 100));
                }

                WriteLine("\n\n");
                Write("Заполнили случайными значениями: ");
                Output_2(ints1);
                Compare(ints1);
                Write("Удалили нечетные значения: ");
                Output_2(ints1);

                



            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
