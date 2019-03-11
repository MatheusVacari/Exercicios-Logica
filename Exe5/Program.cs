using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Você está programando um sistema de festa infantil. O sistema deve emitir um orçamento de acordo com a quantidade de participantes. 
            // O usuário deve digitar a quantidade de participantes e o sistema deve emitir o valor total considerando até 100 pessoas o valor é R$ 35,00 por participante 
            // acima de 100 pessoas o valor passa a ser R$ 45,00 por participante.

            int Participantes = 0, valor = 0;
            

            Console.WriteLine("Informe a quantidade de quantas pessoas irão participar da festa");
                Participantes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Até 100 participante = R$35,00.  Mais de 100 Participantes R$ 45,00.");
            Console.WriteLine("");          
               

            if (Participantes <= 100)
            {
                valor = Participantes * 35;
                Console.WriteLine("O valor será de R$35,00 por partcipante. Valor total será: " + valor+" Reais");
            }
            else
            {
                valor = Participantes * 45;
                Console.WriteLine("O valor será de R$45,00 por participantes. Valor total será: " + valor+" Reais");
            }
            
        }
    }
}
