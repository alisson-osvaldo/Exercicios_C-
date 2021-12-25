using System;

namespace Matriz
{
    internal class Program
    {
        static void Main()
        {
            int LIN = 3;
            int COL = 5;
            int[,] mat = new int[LIN, COL];

            //Declarando a matrix já inicializada com seus valores
            int[,] mat1 = new int[2, 2]{{ 10, 20 }, { 30, 40 }};  
            

            for (int i = 0; i < LIN; i++)
            {
                Console.WriteLine("\nLinha{0}", i);
                for (int j = 0; j < COL; j++)
                {
                    mat[i,j] = j+1;
                    Console.WriteLine("Coluna{0}", j + ": " + mat[i,j]);

                }
            }

            Console.ReadLine();
        }
    }
}
