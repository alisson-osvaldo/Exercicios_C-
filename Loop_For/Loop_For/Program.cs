using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For
{
    internal class Program
    {
        static void Main()
        {
            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
                Console.WriteLine("Valor de num na{0}: {1}", i, num[i]);
            }
            Console.ReadLine();
        }
    }
}
