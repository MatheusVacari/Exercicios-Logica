using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, media = 0;

            Console.WriteLine("Informe o nome do aluno");
                nome1 = Console.ReadLine();
            Console.WriteLine("Informe as notas de " + nome1 + ": ");
                n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota de " + nome1 + ": ");
                n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota de " + nome1 + ": ");
                n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota de " + nome1 + ": ");
                n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quinta nota de " + nome1 + ": ");
                n5 = Convert.ToInt32(Console.ReadLine());

            media = (n1 + n2 + n3 + n4 + n5)/5;

            Console.WriteLine("A média de " + nome1 + " é " + media);

            
        }
    }
}
