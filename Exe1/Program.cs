using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado = 0;

            Console.WriteLine("Informe o primeiro valor!");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            n2 = Convert.ToInt32(Console.ReadLine());

            resultado = (n1 * n2) * n1;

            Console.Write("O resultado será: " + resultado);
            
        }
    }
}
