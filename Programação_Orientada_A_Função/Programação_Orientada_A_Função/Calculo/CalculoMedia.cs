using System;
using System.Collections.Generic;


namespace Calculo
{
    class Media
    {
        //Calcular média do aluno
        public static void Aluno()
        {
            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();
            int qtdNota = 3;
            Console.WriteLine("\nDigite as " + qtdNota + " notas do aluno: " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for(int i = 0; i < qtdNota; i++)
            {
                Console.WriteLine("Digite a nota número {0}: ", i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine("\nA média do aluno " + nome + " é " + media);
            Console.WriteLine("Suas notas são:\n");
            foreach(int nota in notas)
            {
                Console.WriteLine("Notas : " + nota + "\n");
            }

        }

        //função dividir
        public static int Divisao(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor; //resto da divisão
            return quociente;
        } 
    }
}
