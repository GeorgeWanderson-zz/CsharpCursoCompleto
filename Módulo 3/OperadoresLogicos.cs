using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 &&  4 != 5; // E 
            bool c2 = 2 > 3 || 4 != 5; // OU
            bool c3 = ! (2 > 3) && 4 != 5; // NÃO

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("==================");
            bool c4 = 10 < 5;
            bool c5 = c1 || c3 && c4;

           
        }
    }
}
