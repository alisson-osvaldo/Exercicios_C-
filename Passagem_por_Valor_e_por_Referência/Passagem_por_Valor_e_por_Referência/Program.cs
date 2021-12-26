using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_por_Valor_e_por_Referência
{
    internal class Program
    {
        static void Main()
        {
            int num = 10;
            int n   = 10;
            dobrar1(num);
            Console.WriteLine("Por Valor: " + num);
            dobrar2(ref n);
            Console.WriteLine("\nPor Referência: " + n);

            Console.ReadLine();
        }
        //passagem por valor, cria um novo endereço na memória, num continuaria valendo 10 e valor seria uma nova variavel na memória com valor 20
        static void dobrar1(int valor)
        {
            valor *= 2;
        }
        //passagem por referência, usa o endereço de memória da variavel que foi passada como argumento 
        static void dobrar2(ref int valor)
        {
            valor *= 2;
        }
    }
}
