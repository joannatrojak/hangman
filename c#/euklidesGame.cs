using System;

namespace ConsoleApp19
{
    class Program
    {
        static int euklidesGame(int A, int B)
        {
            int count = 0; 

            if (A == B)
            {
                count = A + B;
            }

            if (A > B)
            {
                int difference = A - B;
                count = A - difference;
            }
            if (B > A)
            {
                int difference = B - A;
                count = B - difference;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(euklidesGame(2, 4));
        }
    }
}
