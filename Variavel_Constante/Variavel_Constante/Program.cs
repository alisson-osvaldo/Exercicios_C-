using System;

namespace Variavel_Constante
{
    internal class Program
    {
        //Variavel Constante
        public const int SAIDA_PROGRAMA = 1;

        static void Main()
        {
            while (true) //Se for verdadeiro
            {
                Console.WriteLine("\nDigite " + SAIDA_PROGRAMA + " para sair do programa:");
                int valor = int.Parse(Console.ReadLine());//recebendo do telcado + convertendo string para inteiro

                if (SAIDA_PROGRAMA == valor)
                {
                    break;//pausa
                }
            }           
        } 
    }
}
