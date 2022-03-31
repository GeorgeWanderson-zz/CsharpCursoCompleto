using System;

namespace PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            System.Console.WriteLine("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            System.Console.WriteLine("Idade");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                System.Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else {
                System.Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }


        }
    }
}
