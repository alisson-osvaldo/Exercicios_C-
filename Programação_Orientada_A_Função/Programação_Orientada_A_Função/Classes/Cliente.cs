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
        //Atributos da classe
        public string Nome;
        public string Telefone;
        public string Cpf;

        //Construtor com parâmetros
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        //Construtor sem parâmetros
        public Cliente(){ }

        //Método para gravar no nosso .txt 
        public void Gravar()
        {

            this.olhar();
   
            var clientes = Cliente.lerClientes();
            clientes.Add(this);//adicionando o que tem na nossa instancia de: var cliente = new Cliente();
            if (File.Exists(caminhoBaseClientes())) //3- Verificar se o arquivo exite 
            {
                StreamWriter r = new StreamWriter(caminhoBaseClientes());
                //r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Cpf + ";" ;
                    r.WriteLine (linha);
                }
                r.Close();//fechando a conecção com meu arquivo
            }
        }

        private void olhar()
        {
            Console.WriteLine("\nO cliente " + this.Nome + " foi cadastrado.");
        }

        //Método retornar os dados(clientes) da App.config -> configuration -> appSettings
        public static string caminhoBaseClientes() //2-
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        //Lista de clientes
        public static List<Cliente> lerClientes() //1- Mandando ler os Clientes, q vai chamar o método caminhoBaseClientes()
        {
            var clientes = new List<Cliente>();//instanciando cliente de lista de Clientes

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
                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]); //Instânciando um novo cliente
                        clientes.Add(cliente); //-6 adicionando os clientes na nossa nova instância de cliente
                    }
                }
            }
            return clientes;
        }


    }
}
