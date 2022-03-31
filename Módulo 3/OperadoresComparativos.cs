using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            // menor que
            bool c1 = a < 10;
            bool c2 = a < 20;
            // maior que 
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("----------------");

            bool c5 = a <= 10; // Menor ou igual a 
            bool c6 = a >= 10; // Maior ou igual a 
            bool c7 = a == 10; // igual
            bool c8 = a != 10; // Diferente de 
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
           
        }
    }
}
