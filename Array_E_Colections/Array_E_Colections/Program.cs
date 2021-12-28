using System;
using System.Collections.Generic;

namespace Array_E_Colections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] a = new string[3];
            Console.WriteLine("Array:");
            a[0] = "Jow1";
            a[1] = "Jow2";
            a[2] = "Jow3";

            int size = a.Length;
            Console.WriteLine("Tamanho do Array: " + size);

            foreach (string nome in a)
            {
                Console.WriteLine("Nome: {0}", nome);
            }

            if(Array.Exists(a, e => e.IndexOf("Jow") != -1))//Procurando por parte da String 
            {
                Console.WriteLine("\nEncontrei o Jow no meu ARRAY");

            }
            else
            {
                Console.WriteLine("\nJow não foi encontrado no ARRAY!!! ");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------");
            //Colection
            List<string> a1 = new List<string>();
            Console.WriteLine("\nCollection:");
            a1.Add("Jow");
            a1.Add("Lucas");
            a1.Add("Pedro");

            foreach (string nome in a1)
            {
                Console.WriteLine(nome);
            }

            if(a1.Exists(e => e == "Jow"))//sintax necessaria declarei o 'e' falei q ele é == "jow"
            {
                Console.WriteLine("\nEncontrei o Jow na minha COLECTION");
                
            } else
            {
                Console.WriteLine("\nJow não foi encontrado na COLECTION!!! ");
            }
            

            Console.ReadLine(); 
        }
    }
}
