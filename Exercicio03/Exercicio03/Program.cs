using System;


namespace Exercicio03
{
    internal class Program
    {
        //static int Tam = 3; // variavel global

        static void Main(string[] args)
        {
            
            //string[] produtos = new string[Tam];
            string[] produtos = { "café", "bolo", "chocolate"};



            //Exemplo Foreach--------------------------------------------
            /*foreach (string produto in produtos)
            {
                Console.WriteLine(produto);
            }*/
            //-----------------------------------------------------------


            //Exemplo For------------------------------------------------
            for (int cont = 0; cont < produtos.Length; cont++)
            {
                Console.WriteLine(produtos[cont]);
            }
            //-----------------------------------------------------------


            Console.ReadLine();
        }
    }
}
