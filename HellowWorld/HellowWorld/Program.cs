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
        static int Tam = 3; // variavel global

        //enum enumera cada um dos elementos, e pode mudar seu valor
        enum Cor { azul, amarelo = 12, vermelho };

        static void Main(string[] args)
        {
            //Exemplo utilizando enum----------------------------------------------
            Cor corFavorita = Cor.vermelho;
            Cor corFavoritaDaAna = Cor.amarelo;
            Cor corFavoritaDaPaula = Cor.azul;
            Console.WriteLine("corFavorita: " + (int)corFavorita);//Mostra o valor por trás do elemento
            Console.WriteLine("corFavoritaDaAna: " + corFavoritaDaAna);
            Console.WriteLine("corFavoritaDaPaula: " + (int)corFavoritaDaPaula);
            Console.WriteLine("corFavorita" + (int)corFavorita);
            //---------------------------------------------------------------------


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



            //Switch Case-------------------------------------------
            /*string[] produtos = new string[Tam];

            //int[] quantidade = { 1, 2, 3 };


            switch (Tam)
            {
                case 1:
                    Console.WriteLine(Tam);
                    break;
            }    
            */
            //------------------------------------------------------

            Console.ReadLine();//Espera o Enter
        }
    }
}
