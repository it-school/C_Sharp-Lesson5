using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
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


            //Console.WriteLine("\n\n");

            //int[] december = new int[31];
            //for (int i = 0; i < december.Length; i++)
            //{
            //    december[i] = r.Next(-10, 10);
            //    Console.Write($"{december[i]}\t" );

            //}
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