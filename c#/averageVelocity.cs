using System;

namespace ConsoleApp26
{
    class Program
    {
        static int averageVelocity(int v1, int v2)
        {
            return (2 * (v1 * v2)) / (v1 + v2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(averageVelocity(60, 40));
        }
    }
}
