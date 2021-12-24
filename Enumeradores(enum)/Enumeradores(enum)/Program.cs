using System;

namespace Enumeradores_enum_
{
    internal class Program
    {
        //Enumeradores nos permite criar um tipo próprio com valores prédefinidos,
        //e esses valores poder ser associados ao indice que é a sua posição dentro do conjunto de valores{} do enumerador.
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main()
        {

            DiasSemana ds = (DiasSemana)3; //indice 3 = Quarta

            //pegando o valor do indice
            int indice = (int)DiasSemana.Quarta;

            Console.WriteLine(ds);
            Console.WriteLine("Valor do indice:" + indice);
            
            Console.ReadLine();
        }
    }
}
