using System;


namespace Loop_de_for_while_doWhile
{
    internal class Program
    {
        static void Main()
        {
            //Loop for utilizando length
            int[] num = new int[3];
            Console.WriteLine("\nLoop de for utilizando length:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
                Console.WriteLine("Valor de num na{0}: {1}", i, num[i]);
            }


            //Loop While
            Console.WriteLine("\nLoop do While:");
            int[] num2 = new int[3];
            int j = 0;
            while(j < num2.Length)
            {
                Console.WriteLine(num[j]);
                num[j] = j;
                j++;
            }

            //Loop Do While
            Console.WriteLine("\nLoop Do While");
            string senha = "123";
            string senhaUser;
            int tentativas = 0;
            do
            {
                Console.WriteLine("Informe sua senha:");
                senhaUser = Console.ReadLine();
                tentativas++;
            } while (senhaUser != senha);
            Console.WriteLine("Senha Correta: OK \nTentativas:{0}", tentativas);


            //Loop Foreach
            Console.WriteLine("\nLoop Foreach");
            int[] num3 =new int[3]{11,22,33};
            foreach (int n in num3)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
