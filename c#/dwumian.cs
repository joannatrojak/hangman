using System;

namespace ConsoleApp20
{
    class Program
    {
        static int silnia(int n)
        {
            int r = 1; 
            for (int i = 1; i < n + 1; i++)
            {
                r = r * i; 
            }
            return r;
        }
        static int pascalTriangle(int n, int k)
        {
            return silnia(n) / (silnia((n - k)) * silnia(k));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(pascalTriangle(7, 3));
        }
    }
}
