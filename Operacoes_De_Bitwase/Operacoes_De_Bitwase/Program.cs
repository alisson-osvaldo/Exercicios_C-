using System;

namespace Operacoes_De_Bitwase
{
    internal class Program
    {
        static void Main()
        {
            /* Usar tabela binaria
                00000000-0      00000110-6      00010100-20
                00000001-1      00000111-7
                00000010-2      00001000-8
                00000011-3      00001001-9
                00000100-4      00001010-10
                00000101-5      00001011-11

            << Dobra valor em bit
            >> Metade do valor em bit

             */

            //Exe. deslocando esquerda <<
            //Pega o valor em bit ex bit5: 00000101-5  pega apenas o 101 e adiciona os zeros na esquerda ou direita ex <<:  000101+00 = 20bit 
            int num = 5;    //tenho 5: 00000101
            num = num << 2; //descoloquei 2 para a esquerda: 00010100-20
            Console.WriteLine("Esquerda: " + num);


            //Exe. deslocando direita >> exe: 1011 apaga as ultimas 2 000000+10 = 00000010-2
            int num1 = 11;    //tenho 11: 00001011-11
            num1 = num1 >> 2; //descoloquei 2 para a direita: 00000010-2
            Console.WriteLine("Direita: " + num1);


            Console.ReadLine();
        }
    }
}
