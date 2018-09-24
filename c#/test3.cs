using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            int c = 0; 
            
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 42 && b != 42)
                {
                    c += 1;
                }
                Console.WriteLine(a);
                b = a;
                if (c == 3)
                {
                    break;
                }
            }

        }
    }
}
