using System;
using System.Configuration;
using System.IO;


namespace Diretorio
{
    class Arquivo
    {
        //Retorne esse caminho do webConfig (App.config) rota de onde está nossos arquivos .txt
        public static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"]; 
        }

        public static void Ler(int numeroArquivo)
        {
            //Aqui ele lê apenas o arquivo 1 e para 
            string arquivoComCaminho = caminhoArquivo() + "teste" + numeroArquivo + ".txt"; //lê o numero do arquivo e soma +1 para ir para o próximo
            Console.WriteLine("============================= Lendo Aquivos ==============================\n" + arquivoComCaminho + "\n================================");
            if (File.Exists(arquivoComCaminho))//Se exite arquivoComCaminho fassa isso
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))//recebendo arquivo.txt (Parâmetro)
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine("\n" + linha);
                    }
                }
            }

            //Aqui ele lê todos os arquivos até acabar
            string arquivoComCaminho2 = ConfigurationManager.AppSettings["CaminhoArquivo"] + "teste" + numeroArquivo + ".txt";//passando a appSeting da App.config

            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            } 

            Console.ReadLine();
        }
    }
}
