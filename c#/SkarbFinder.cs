using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void skarbFinder(int[,] coordinates, int howMany)
        {
            Dictionary<string, int>[] information = new Dictionary<string, int>[]
                {
                    new Dictionary<string, int>(),
                    new Dictionary<string, int>(),
                    new Dictionary<string, int>(),
                    new Dictionary<string, int>()
                };
            information[0].Add("y", 1);
            information[1].Add("y", -1);
            information[2].Add("x", 1);
            information[3].Add("x", -1);
            int countX = 0;
            int countY = 0;

            for (int i = 0; i < howMany; i++)
            {
                var direction = information[coordinates[i, 1]];
                if (direction.ContainsKey("x"))
                {
                    countX += direction["x"] * coordinates[i, 1];
                }
                if (direction.ContainsKey("y"))
                {
                    countY += direction["y"] * coordinates[i, 1];
                }
            }
            Console.WriteLine("X: {0} i Y: {1}", countX, countY);

        }
        static void Main(string[] args)
        {
            int[,] coordinates = { { 0, 1 }, { 0, 2 }, { 1, 2 }, { 2, 3 } };
            int howMany = coordinates.GetLength(0);
            skarbFinder(coordinates, howMany);
        }
    }
}
