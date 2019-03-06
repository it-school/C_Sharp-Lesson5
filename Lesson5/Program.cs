using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        public static void PrintAr3(string[] Fathers, string[][] Children)
        {
            for (int i = 0; i < Fathers.Length; i++)
            {
                Console.WriteLine("Отец : {0}; Его дети:", Fathers[i]);
                for (int j = 0; j < Children[i].Length; j++)
                    Console.Write(Children[i][j] + " ");
                Console.WriteLine();
            }
        }//PrintAr3
        
        static void Main(string[] args)
        {
            int[] first = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            foreach (var item in first)
            {
                Console.Write($"{item}, ");
            }


            //Console.WriteLine('\n');
            //Console.WriteLine(first);


            //int[] second = new int[first.Length];
            //Array.Copy(first, 3, second, 4, 5);
            //Console.WriteLine("\n\nArray.Copy(first, 3, second, 4, 5);");
            //foreach (var item in second)
            //{
            //    Console.Write($"{item}, ");
            //}

            //int[] bb = new int[100000];
            //for (int i = 0; i < bb.Length; i++)
            //{
            //    bb.SetValue(r.Next(1, 1000), i);
                // bb[i] = r.Next(1, 1000);
                //                Console.WriteLine(bb[i]+" ");
            //}
            
            /*
            int w = 10;
            String s = "10 7";

            Int32.TryParse(s, out w);
            
            try
            {
                w = Int32.Parse(s);
            }
            catch (Exception e)
            {
                w = 0;
                // Console.WriteLine(e.Message);
            }

            Console.WriteLine(w);
            */

            //int[,] c = {
            //                { 1, 2, 3 },
            //                { 4, 5, 6 },
            //                { -1, -2, -3 },
            //                { -4, -5, 0 }
            //            };

            //Console.WriteLine("\n\n");
            //Random r = new Random();
            //for (int row = 0; row < c.GetLength(0); row++)
            //{
            //    for (int column = 0; column < c.GetLength(1); column++)
            //    {
            //        c[row, column] = r.Next(-100, 100); // [-100, 100)
            //        Console.Write($"{c[row, column]}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n\n");
            //int[][] jaggedArray = { new int[3], new int[5], new int[4] };
            //for (int i = 0; i < jaggedArray.GetLength(0); i++)
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //        jaggedArray[i][j] = r.Next(-10, 10);

            //foreach (var arrayRow in jaggedArray)
            //{
            //    foreach (var itemsOfRow in arrayRow)
            //        Console.Write($"{itemsOfRow}\t");
            //    Console.WriteLine();
            //}

            //int Fcount = 3;
            //string[] Fathers = new string[Fcount];
            //Fathers[0] = "Николай"; Fathers[1] = "Сергей";
            //Fathers[2] = "Петр";
            //string[][] Children = new string[Fcount][];
            //Children[0] = new string[] { "Ольга", "Федор" };
            //Children[1] = new string[] { "Сергей", "Валентина", "Ира", "Дмитрий", "Ира", "Дмитрий" };
            //Children[2] = new string[] { "Мария", "Ирина", "Надежда" };
            //PrintAr3(Fathers, Children);

            //Console.WriteLine("\n\n");

            //int[] december = new int[31];
            //for (int i = 0; i < december.Length; i++)
            //{
            //    december[i] = r.Next(-10, 10);
            //    Console.Write($"{december[i]}\t" );
            //}
            
            // Пузырьковая сортировка
            /*
            for (int j = 0; j < b.Length - 1; j++)
            {
                for (int i = 0; i < b.Length - 1 - j; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        t = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = t;
                    }
                }
            }
            Array.Sort(b);
            */
            
            //int day = 1;
            //foreach (var item in december)
            //{
            //    if (item < 0)
            //        break;
            //    day++;
            //}
            //Console.WriteLine("first cold day:"+day);

            //int counter = 0; 
            //foreach(var item in december)
            //{
            //    if (item > 0)
            //        counter++; 

            //}
            //Console.WriteLine(counter);
        }
    }
}
