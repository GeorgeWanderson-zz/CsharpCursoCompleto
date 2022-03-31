using System;
using System.Globalization;

namespace ExercicioAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3; // Recebe as notas

        public double NotaFinal() // Calcula as 3 notas do aluno
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() // Verifica com condição de verdadeiro ou falso se o aluno foi aprovado
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante() // Verifica se o aluno foi aprovado, caso não, calcula o valor que faltou para ser aprovado
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }

}
