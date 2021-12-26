using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_Params
{
    internal class Program
    {
        static void Main()
        {
            //Params: Permite a entrada de zero ou mais parâmetros para dentro de uma função/método
            Somar(5, 5, 2, 1);

            Console.ReadKey();
        }

        static void Somar(params int[]n)
        {
            int res = 0;

            if(n.Length < 1)
            {
                Console.WriteLine("Não existe valores a serem somados!!!");
            } else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para a soma: {0}", n[0]);//é necessario mais de um valor para poder somar
            } else { 
                for(int i = 0; i < n.Length; i++)
                {
                    res += n[i];
                }
            }
            Console.WriteLine("A soma do valores é {0}", res);
                           
        }
    }
}
