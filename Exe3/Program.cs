using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para “Calcular o estoque médio de uma peça”, sendo que 
            // ESTOQUEMÉDIO = (QUANTIDADE MÍNIMA + QUANTIDADE MÁXIMA) /2

            double EstoqueMedio = 0, QuantidadeMinima = 0, QuantidadeMaxima = 0;


            Console.WriteLine("Insira a quantidade minima no estoque!");
            QuantidadeMinima = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade máxima para o estoque!");
            QuantidadeMaxima = Convert.ToDouble(Console.ReadLine());

            EstoqueMedio = (QuantidadeMinima + QuantidadeMaxima) / 2;

            Console.WriteLine("O estoque médio da peça será: " + EstoqueMedio);
        }
    }
}
