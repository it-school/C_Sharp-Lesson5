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
            double[] first = { 1, 2, 3, 4, 5, 6, 4, 8, 4, 4 };

            Random r = new Random();
            for (int i = 0; i < first.Length; i++)
            {
                first[i] = r.Next(0,100) / 50.0 - 1;
                Console.WriteLine(first[i]);
            }

            int[] a = new int[31];
            int common = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next()%21; // r.Next(0, 21);
                Console.WriteLine(a[i]);
                common += a[i];
            }
            Console.WriteLine($"Common = {common}");
            Console.WriteLine($"Avg = {(double)common/a.Length}");

            int k = 5;
            Console.WriteLine(a[k]%2 == 0? "Yes": "No");
            /*

         int n = 0, k = -1;
         while (n < 3)
         {
             k = Array.IndexOf(first, 4, k+1);
             n++;
             Console.WriteLine(k);
         }


      foreach (var item in first)
      {
          Console.Write($"{item}, ");
      }

      Console.WriteLine('\n');
      for (int i = 0; i < first.Length; i++)
      {
          Console.Write(first[i] + ", " );
      }

      Console.WriteLine('\n');
      Console.WriteLine(first);


      int[] second = new int[first.Length];
      //Array.Copy(first, 3, second, 4, 5);
      Array.Copy(first, second, first.Length);
      Console.WriteLine("\n\nArray.Copy(first, 3, second, 4, 5);");
      first[0] = 555;
      foreach (var item in second)
      {
          Console.Write($"{item}, ");
      }

      Random r = new Random();
      int[] bb = new int[100];
      for (int i = 0; i < bb.Length; i++)
      {
          //bb.SetValue(r.Next(1, 1000), i);
          bb[i] = r.Next(1, 1000);
          Console.WriteLine(bb[i] + " ");
      }
      */
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
            //                { 1, 2, 3 }, { 4, 5, 6 },  { -1, -2, -3 }, { -4, -5, 0 }
            //            };
            //int min = c[0,0];
            //foreach (var item in c)
            //{
            //    if (item < min)
            //        min = item;
            //}
            //Console.WriteLine(min);

            //min = c[0, 0];
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        if (c[i, j] < min)
            //            min = c[i, j];
            //        c[i, j] = 0;
            //    }
            //}
            //Console.WriteLine(min);

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

            //Random r = new Random();
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

            int Fcount = 3;
            string[] Fathers = new string[Fcount];
            Fathers[0] = "Николай";
            Fathers[1] = "Сергей";
            Fathers[2] = "Петр";
            string[][] Children = new string[Fcount][];
            Children[0] = new string[] { "Ольга", "Федор" };
            Children[1] = new string[] { "Сергей", "Валентина", "Ира", "Дмитрий", "Ира", "Дмитрий" };
            Children[2] = new string[] { "Мария", "Ирина", "Надежда" };
            PrintAr3(Fathers, Children);

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
