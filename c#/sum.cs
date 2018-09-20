using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby do dodania mniejsze od 200");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a < 200 && b < 200){
                int suma = a + b;
                Console.WriteLine(suma);
            }
        }
    }
}
