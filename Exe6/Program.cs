using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Você está programando um sistema para uma empresa de recursos humanos.
            // De acordo com o tempo de experiência do candidato você deve informar 
            // ao recrutador o nível do candidato.Considere:

            //   Menor que 2 anos → Júnior
            //   Entre 2 e 5 anos → Pleno
            //   Acima de 5 anos → Sênior

            double Experiencia = 0;
            string NomeCantidado;

            Console.WriteLine("Informe o nome");
                NomeCantidado = Console.ReadLine();

            Console.WriteLine("Informe o tempo de experiência do candidato");
                Experiencia = Convert.ToDouble(Console.ReadLine());

            if(Experiencia <= 2)
            {
                Console.WriteLine("O candidato(a) " + NomeCantidado + " tem o nível: Júnior");
            }
            else if(Experiencia <= 5)
            {
                Console.WriteLine("O candidato(a) " + NomeCantidado + " tem o nível: Pleno");
            }
            else
            {
                Console.WriteLine("O candidato(a) " + NomeCantidado + " tem o nível: Sênior");
            }
        }
    }
}
