using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um Algoritmo que lê o nome e as 4 notas bimestrais de um aluno. 
           // Em seguida o Algoritmo calcula e escreve a média obtida e se o aluno foi aprovado ou reprovado. 
           // Considere a média 5 para aprovação
            
            String NomeAluno;
            Double Nota1 = 0, Nota2 = 0, Nota3 = 0, Nota4 = 0, Media = 0;

            Console.WriteLine("Informe o nome do aluno");
                 NomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a nota do(a): " + NomeAluno);

                    Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota do(a): " + NomeAluno);

                     Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota do(a): " + NomeAluno);

                      Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota do(a): " +NomeAluno);

                       Nota4 = Convert.ToDouble(Console.ReadLine());

                Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            Console.WriteLine("O " + NomeAluno + " teve a média de " + Media + ", então: ");

            if (Media >= 5)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else {
                Console.WriteLine("Aluno reprovado");
            }
                
            

        }
    }
}
