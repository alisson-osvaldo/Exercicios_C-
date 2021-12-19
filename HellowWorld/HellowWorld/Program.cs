using System; //manipular coisas do sistema operacional do usuario
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks; Apenas se for usar varios nucleos do processador
//using System.IO; Para manipular pastas 

namespace HellowWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int - 123
            //Float - 12.6
            //Bool - true ou false
            //String - abcd
            //Char - 'a' caracter

            String nome = "";

            Console.WriteLine("Seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);
               

            float velocidadeF1 = 294.6f; //Float vai f no final
            bool verdadeiroOuFalso = true;

            //dynamic pode mudar a tipagem da variavel
            dynamic cor_favorita = "Vermelho";
            Console.WriteLine("");
            Console.WriteLine(cor_favorita);
            cor_favorita = 123;
            Console.WriteLine("Passando para int:" + cor_favorita);

            //Divisão utilizar float 
            //float div = 5.0f/2;
            //Console.WriteLine(div);


            Console.ReadLine();//Espera o Enter
        }
    }
}
