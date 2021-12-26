using System;

namespace Argumento_Out
{
    internal class Program
    {
        static void Main()
        {
            int dividend, divis, quocient, rest;
            dividend = 10;
            divis = 3;
            quocient = dividir(dividend, divis, out rest);

            Console.WriteLine("{0}/{1}: Quociente={2} e Resto={3}", dividend, divis, quocient, rest);
            Console.ReadLine();
        }

        static int dividir(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo/divisor;
            resto = dividendo%divisor; //resto da divisão
            return quociente;
        }
    }
}
