using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string Cpf;

        public void Gravar()
        {

        }

        public static string caminhoBaseClientes() //2- vai acessar este método, q vai pegar os dados da configuração e vai retornar
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }


        public static List<Cliente> lerClientes() //1- Mandando ler os Clientes, q vai chamar o método caminhoBaseClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes())) //3- Verificar se o arquivo exite 
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))//-4 Se ele existe leia esse arquivo
                {
                    string linha; //-5 guardar aqui esses dados
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        if (i == 1) continue; //Para não ler a primeira linha do Clientes.txt
                        var clienteArquivo = linha.Split(';'); //vai separar por ';' , no caso do Clientes.txt vai nos retornar um Array de 3 posições
                        var cliente = new Cliente(); //Instânciando um novo cliente
                        //Preenchendo as propriedades do do Cliente
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.Cpf = clienteArquivo[2];
                        
                        clientes.Add(cliente); //-6 adicionando os clientes na nossa nova instância de cliente
                    }
                }
            }
            return clientes;
        }

    }
}
