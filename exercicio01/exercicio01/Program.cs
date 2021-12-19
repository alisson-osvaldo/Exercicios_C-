using System;

//Pegue uma idade e informe se é uma criança, adolecente, adulto ou idoso. 
//ultilizando laço de repetição, perguntar se gostaria de repetir a pergunta.

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;

            do
            {
                Console.WriteLine("Informe sua idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 11)
                {
                    Console.WriteLine("Criança: " + idade);
                }
                else if (idade <= 18)
                {
                    Console.WriteLine("Adolecente: " + idade);
                }
                else if (idade <= 60)
                {
                    Console.WriteLine("Adulto: " + idade);
                }
                else
                {
                    Console.WriteLine("Idoso: " + idade);
                }

                Console.WriteLine("\nRepetir? 'S' \n Não Repetir? 'N ");
                op = char.Parse(Console.ReadLine());


            } while (op == 'S' || op == 's');
            
        }
    }
}
