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


        //Método retornar os dados(clientes) da App.config -> configuration -> appSettings
        public static string CaminhoBase() //2-
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }


        //virtual -Quer dizer que essemétodo ou propriedade pode ser sobscrita
        public virtual void Gravar()
        {
            var clientes = Cliente.lerClientes();
            Cliente c = new Cliente(this.Nome, this.Cpf, this.Telefone);
            clientes.Add(c);//adicionando o que tem na nossa instancia de: var cliente = new Cliente();
            if (File.Exists(CaminhoBase())) //3- Verificar se o arquivo exite 
            {
                StreamWriter r = new StreamWriter(CaminhoBase());
                foreach (Cliente user in clientes)
                {
                    var linha = user.Nome + ";" + user.Telefone + ";" + user.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();//fechando a conecção com meu arquivo
            }
        }


        //Lista de clientes
        public static List<Cliente> lerClientes() //1- Mandando ler os Clientes, q vai chamar o método CaminhoBaseClientes()
        {
            var clientes = new List<Cliente>();//instanciando cliente de lista de Clientes

            if (File.Exists(CaminhoBase())) //3- Verificar se o arquivo exite 
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBase()))//-4 Se ele existe leia esse arquivo
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
