using System;

namespace ConsoleApp12
{
    class Program
    {
        static double glutton(int time)
        {
            return 86400 / time;
        }
        static double howManyBoxes(int box, int[] gluttons)
        {
            int sum = 0; 
            for (int i = 0; i< gluttons.Length; i++)
            {
                sum += Convert.ToInt32(glutton(gluttons[i]));
            }
            double boxes = sum / box;
            return boxes;
        }
        static void Main(string[] args)
        {
            int[] gluttons = { 3600, 1800 };
            Console.WriteLine(howManyBoxes(10, gluttons));
        }
    }
}
