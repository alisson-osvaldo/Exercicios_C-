using System;

namespace Array_Vetor
{
    internal class Program
    {
        static void Main()
        {
            //Declarando um array de 3
            int[] n=new int[3]; 
            n[0] = 00;
            n[1] = 11;
            n[2] = 22;

            //Declarando um array de 3 posições, já inicializado
            int[] vet=new int[3] {0, 1, 2};

            //O Array será de apenas 3 indices
            int[] vet1 = { 1, 2, 3 };

            Console.WriteLine("vet:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("\nn:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(n[i]);
            }


            //Array de String
            Console.WriteLine("\nArray de String:");
            string[] veiculos =new string[3];
            veiculos[0] = "Avião";
            veiculos[1] = "Carro";
            veiculos[2] = "Ônibus";
            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(veiculos[i]);
            }
            
            Console.ReadLine();
        }
    }
}
