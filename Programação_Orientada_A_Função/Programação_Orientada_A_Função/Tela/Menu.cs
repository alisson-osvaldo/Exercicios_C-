using System;
using Calculo;
using Diretorio;

namespace Tela
{
    class Menu
    {
        //recendo um valor const para as opções
        public const int DIVIDIR = 1;
        public const int CALCULO_MEDIA = 2;
        public const int LER_ARQUIVO = 3;
        public const int SAIR = 0;

        public static void Criar()
        {
            while (true)
            {
                string msg = "Olá usuário bem vindo ao programa: Utilizando Programação Funcional" +
                "\n\nEscolha uma das Opções a baixo:" +
                "\n 0 - Sair" +
                "\n 1 - Dividir" +
                "\n 2 - Média" + 
                "\n 3 - Buscar Arquivo";
                Console.WriteLine(msg);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIR)
                {

                    Console.WriteLine("Tchal!!!");

                }
                else if (valor == DIVIDIR)
                {

                    Console.WriteLine("\n=========================== Divisão ============================");
                    Console.WriteLine("informe o dividendo:");
                    int dividend = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o divisor:");
                    int divis = int.Parse(Console.ReadLine());

                    int quocient = Media.Divisao(dividend, divis, out int rest);

                    Console.WriteLine("\n{0}/{1}: Quociente={2} e Resto={3}", dividend, divis, quocient, rest);

                }
                else if (valor == CALCULO_MEDIA)
                {

                    Console.WriteLine("\n=========================== Média ============================");
                    Media.Aluno();

                } else if (valor == LER_ARQUIVO)
                {
                    Arquivo.Ler(1);
                }
                else
                {
                    Console.WriteLine("Opção informada não exite!!!");
                }

                Console.ReadLine();

            }
        }    
    }
}
