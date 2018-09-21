using System;

namespace ConsoleApp24
{
    class Program
    {
        static int addition(int a, int b)
        {
            return a + b;
        }
        static int substraction(int a, int b)
        {
            return a - b;
        }
        static int multiplication(int a, int b)
        {
            return a * b;
        }
        static double division(int a, int b)
        {
            try
            {
                if (a != 0 || b != 0){
                    return a / b; 
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured: {0}", e);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(addition(2, 5));
            Console.WriteLine(substraction(2, 5));
            Console.WriteLine(multiplication(2, 5));
            Console.WriteLine(division(1, 1));
        }
    }
}
