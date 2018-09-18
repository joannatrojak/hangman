using System;

namespace ConsoleApp6
{
    class Program
    {
        static int nwd(int n, int m)
        {
            while (m != 0)
            {
                int temp = m;
                m = n % m;
                n = temp;
            }
            return n;
        }
        static int nww(int n, int m)
        {
            return (n * m) / nwd(n, m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(nww(12, 15));
        }
    }
}
