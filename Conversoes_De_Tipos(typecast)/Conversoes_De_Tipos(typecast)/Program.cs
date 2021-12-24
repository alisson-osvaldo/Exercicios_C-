using System;

namespace Conversoes_De_Tipos_typecast_
{
    internal class Program
    {
        static void Main()
        {
            //Conversão implícita, é feito altomáticamente
            int m1 = 10;
            float m2 = m1;

            //Conversão explicita, é feito manualmente
            float n1 = 10.5f;
            int n2 = (int)n1; //type cast
            Console.WriteLine(n2);

            Console.ReadLine();
        }

       
    }
}
