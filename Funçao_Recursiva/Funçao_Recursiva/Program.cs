using System;
using System.IO;


//Função recursiva: Para que não tenha que chamar a mesma função várias vez, chama ela uma vez e ela faz o loop de quantas vez forem necessarias

namespace Funçao_Recursiva
{
    internal class Program
    {
        static void Main()
        {
            //lerArquivo(@"C:\Users\aliss\OneDrive\Área de Trabalho\Nova pasta\teste1.txt"); //Crie um arquivo .txt com conteudo para mostrar, passe a rota a rota como parâmetro 
            lerArquivo(1);//passando como parametro o número do arquivo ex: teste1.txt 
        }

        private static void lerArquivo(int numeroArquivo)
        {
            //Aqui ele lê apenas o arquivo 1 e para 
            string arquivoComCaminho = @"C:\Users\aliss\OneDrive\Área de Trabalho\Nova pasta\teste" + numeroArquivo + ".txt"; //lê o numero do arquivo e soma +1 para ir para o próximo
            if (File.Exists(arquivoComCaminho))//Se exite arquivoComCaminho fassa isso
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))//recebendo arquivo.txt (Parâmetro)
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            //Aqui ele lê todos os arquivos até acabar
            string arquivoComCaminho2 = @"C:\Users\aliss\OneDrive\Área de Trabalho\Nova pasta\teste" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                lerArquivo(numeroArquivo + 1);
            } 

            Console.ReadLine();
        }


    }
}
