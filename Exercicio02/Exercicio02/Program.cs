using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Dada uma equação do segundo grau (ax2 + bx + c = 0), elabore um procedimento que calcule as raízes
desta equação de acordo com a Fórmula de Báskara e apresente o seu resultado na tela.
x = -b +- √▲      onde     ▲ = b2 – 4ac
       2a                  ▲ > 0: duas raízes reais e diferentes
			   ▲ = 0: duas raízes reais e iguais
			   ▲ < 0: não há raízes reais
*/

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe c: ");
            int c = int.Parse(Console.ReadLine());

            Baskara(a, b, c);

            Console.ReadLine();
        }

        //procedimento que apresenta as raízes de uma equação do 2o grau
        static void Baskara(int a, int b, int c)
        { 
       
            double delta = Math.Pow(b, 2) * (-4 * a * c);
            
            Console.WriteLine(delta);
            
            if(delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Raízes iguais: " + x1, x1);
            } else if (delta == 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Raízes iguais: " + x1, x1);
            } else
            {
                Console.WriteLine("Não há raízes reais");
            }
           
            
        }
    }
}
