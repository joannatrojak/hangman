using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static double distanceFromcenter(int X, int Y)
        {
            int[] center = { 0, 0 };
            return Math.Round(Math.Sqrt(Math.Pow(X - center[0], 2) + Math.Pow(Y - center[1], 2)));
        }
        static void sortDistances(int[,] distances)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < distances.GetLength(0); i++)
            {
                int X = distances[i, 0];
                int Y = distances[i, 1];
                result.Add(Convert.ToInt32(distanceFromcenter(X, Y)));
            }
            result.Sort();
            result.ForEach(Console.WriteLine);
        }
        static void Main(string[] args)
        {
            int[] X = { 1, -1 };
            int[,] distances = { { 0, 0 }, { 5, 5 }, { 1, -1 } };
            sortDistances(distances);
            //Console.WriteLine(distances[0, 0]);
            //Console.WriteLine(distanceFromcenter(X));
        }
    }
}
