using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um Algoritmo que lê o nome, as 4 notas bimestrais e o número faltas de um aluno. 
            //Em seguida o Algoritmo calcula e escreve a média obtida e se o aluno foi aprovado, reprovado ou está de recuperação considerando que se o aluno teve mais de 10 faltas ele está reprovado, 
           //se as faltas foram inferiores à 10 mas a nota menor do que 5 ele está de recuperação, e se as faltas foram menor do que 10 e a nota maior ou igual a 5, ele está aprovado.


            String NomeAluno;
            Double Nota1 = 0, Nota2 = 0, Nota3 = 0, Nota4 = 0, Faltas = 0, Media = 0;
        

            Console.WriteLine("Informe o nome do aluno(a)");
                NomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a nota: ");
                Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Infrome a nota: ");
                Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe A nota: ");
                Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota: ");
                Nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe as faltas: ");
                Faltas = Convert.ToDouble(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Faltas > 10)
            {
                Console.WriteLine("O aluno(a) " + NomeAluno + " está REPROVADO pro excesso de falta. MÉDIA/FALTAS: " + Media + " / " + Faltas);
            }
            else if (Media > 5)
            {
                Console.WriteLine("O aluno(a) " + NomeAluno + " está APROVADO. MÉDIA/FALTAS: " + Media + " / " + Faltas);   
            }
            else
            {
                Console.WriteLine("O aluno(a) "+NomeAluno+ " está de RECUPERAÇÃO. MÉDIA/FALTAS: " + Media + " / " + Faltas);
            }
        }
    }
}
