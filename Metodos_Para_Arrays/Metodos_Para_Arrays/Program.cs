using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Para_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] vet3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 100 } };

            //Random para gerar valores aleatórios
            Console.WriteLine("Ramdom:");
            Random random = new Random();
            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = random.Next(10);//Pode usar Next com valor minimo e maximo (min,max)
            }
            foreach (int v1 in vet1)
            {
                Console.WriteLine(v1);
            }
            Console.WriteLine("\n------------------------------------------------------------");


            //Public static int BinarySearch(Array,Valor): Vai me retornar a posição do elemento procurado.
            Console.WriteLine("\nBinarySearch:");
            int buscar = 5;
            int posicao = Array.BinarySearch(vet1, buscar);
            if (posicao < 0)
            {
                Console.WriteLine("O valor {0} não existe no Array!!!", buscar);
                Console.WriteLine("\n------------------------------------------------------------");
            }
            else 
            { 
                Console.WriteLine("O valor {0} está na posição {1}", buscar, posicao);
                Console.WriteLine("\n------------------------------------------------------------");
            }


            //Public static void Copy(Ar-origem, Ar_destino, qtde_elementos): Faz a copia de um Array para outro
            Console.WriteLine("\nCopy:");
            Array.Copy(vet1, vet2, vet1.Length);
            foreach (int n in vet2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n------------------------------------------------------------");


            //Public static void CopyTo( destino, apartir_dessa_posição): 
            Console.WriteLine("\nCopyTo:");
            vet1.CopyTo(vet3, 0);//copiar apartir do indice 0 ou seja todos
            foreach(int n in vet3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n------------------------------------------------------------");


            //public int GetLowerBound( dimensão ): mostra o menor indice do vetor ou matriz, dimensão: Se é uma matriz ou um Array, dimensão==Array 
            Console.WriteLine("\nGetLowerBound:");
            int menorIndiceVetor = vet1.GetLowerBound(0);
            int menorIndiceMatrix_D1 = matriz.GetLowerBound(1);//aqui vai a coluna da matriz
            Console.WriteLine("Menor indice do vet1 indice:{0}", menorIndiceVetor);
            Console.WriteLine("\n------------------------------------------------------------");


            //public int GetUpperBoind( dimensão): mostra o maior indice do vetor ou matriz
            Console.WriteLine("\nGetUpperBoind");
            int maiorIndiceVetor = vet1.GetUpperBound(0);
            int maiorIndiceMatrix_D1 = matriz.GetUpperBound(1);//aqui vai a coluna da matriz
            Console.WriteLine("Maior indice do vet1 indice:{0}", maiorIndiceVetor);
            Console.WriteLine("\n------------------------------------------------------------");


            //public long GetLongLength( dimensão ): mostra a quantidade de indices do vetor ou matriz
            Console.WriteLine("\nGetLongLength:");
            long qtdeElementoVetor = vet1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos {0}", qtdeElementoVetor);
            Console.WriteLine("\n------------------------------------------------------------");


            //public object GetValue : vai retornar um valor apartir de um indice.
            Console.WriteLine("\nGetValeu:");
            int valor0 = Convert.ToInt32(vet1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1,2));//indicou linha 1 e coluna 2
            Console.WriteLine("Valor da posição 3 do vet1: {0}", valor0);
            Console.WriteLine("\n------------------------------------------------------------");


            //public static int IndexOf(Array, Valor): vai retornar o indice do valor que indicar no segundo parâmetro
            Console.WriteLine("\nIndexOf:");
            int indice1 = Array.IndexOf(vet1, 3);
            if (indice1 < 0)
            {
                Console.WriteLine("O valor não existe no Array!!!");
                Console.WriteLine("\n------------------------------------------------------------");
            } else {
                Console.WriteLine("Maior indice com valor 3: {0}", indice1);
                Console.WriteLine("\n------------------------------------------------------------");
            }


            //public static in LastIndexOf( Array, Valor ): vai retornar o ultimo indice do valor passado
            Console.WriteLine("\nLastIndexOf:");
            int indice2 = Array.LastIndexOf(vet1, 3);
            if(indice2 < 0)
            {
                Console.WriteLine("O valor não existe no Array!!!");
                Console.WriteLine("\n------------------------------------------------------------");
            } else
            {
                Console.WriteLine("Menor indice com valor 3: {0}", indice2);
                Console.WriteLine("\n------------------------------------------------------------");
            }


            //public static void Reverse( Array ): ele inverte a ordem dos elementos ex: 12345 == 54321 
            Console.WriteLine("\nReverse:");
            Array.Reverse(vet1);
            Console.WriteLine("Revertendo vet1 : ");
            foreach (int n in vet1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n------------------------------------------------------------");


            //public void SetValue(object valor, long pososição): nos permite definir um valor em uma posição do nosso vetor
            Console.WriteLine("\nSetValue:");
            //vet2.SetValue(9, 0); //ex:Setando valor 9 no indice 0
            for(int i = 0; i < vet2.Length; i++)
            {
                vet2.SetValue(0,i);//()Setando 0 para todo o vetor já que estamos percorrendo indice por indice com i
            }
            foreach (int n in vet2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n------------------------------------------------------------");


            //public static void Sort(Array): Ordenar em ordem crecente ou decrecente, em decresente usar o Reverse.
            Console.WriteLine("\nSetValue:");
            Array.Sort(vet1);
            Array.Sort(vet2);
            Array.Sort(vet3);
            Array.Reverse(vet3);
            Console.WriteLine("\nVet1 ordem crecente:");
            foreach (int n in vet1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVet2 ordem crecente:");
            foreach (int n in vet2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVet3 ordem decrecente:");
            foreach (int n in vet3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n------------------------------------------------------------");




            Console.ReadLine();
        }
    }
}
