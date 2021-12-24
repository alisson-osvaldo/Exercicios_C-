using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main() 
        {
            char escolha;
            int tempo = 0;

            inicio://goto: para onde vamos voltar

            Console.Clear();    

            Console.WriteLine("Viagem de:");
            Console.WriteLine("Belo Horizonte/MG para Curitiba/PR");
            Console.WriteLine("Escolha o tranporte: [a]Avião  -  [b]Carro  -  [c]}ônibus");
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'b':
                case 'B':
                    tempo = 480;
                    break;
                case 'c':
                case 'C':
                    tempo = 660;
                    break;

                default://caso nenhuma das opções 
                    tempo =-1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Tranporte indisponível");  
            } else
            {
                Console.WriteLine("Tempo {0} minutos", tempo);
            }

            Console.Write("\nEscolher outro transporte? SIM='S' Não='N'");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 'S' || escolha == 's')
            {
                goto inicio;
            } else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa!");
            }
            Console.ReadLine();
        }
    }
}
