using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Cliente  // <- Usuario herdando de Cliente
    {

        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public Usuario() { }


        //Método retornar os dados(usuarios) da App.config -> configuration -> appSettings
        public static string CaminhoBase() //2-
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }

        //override -sobrescrever
        public override void Gravar()
        {
            this.olhar();

            var usuarios = Usuario.lerUsuarios();
            usuarios.Add(this);//adicionando o que tem na nossa instancia de: var cliente = new Cliente();
            if (File.Exists(CaminhoBase())) //3- Verificar se o arquivo exite 
            {
                StreamWriter r = new StreamWriter(CaminhoBase());
                foreach (Usuario user in usuarios)
                {
                    var linha = user.Nome + ";" + user.Telefone + ";" + user.Cpf + ";";
                    r.WriteLine(linha);
                }
                r.Close();//fechando a conecção com meu arquivo
            }
        }


        private void olhar()
        {
            Console.WriteLine("\nO cliente " + this.Nome + " foi cadastrado.");
        }


        //Lista de Usuarios
        public static List<Usuario> lerUsuarios()
        {
            var usuarios = new List<Usuario>();

            if (File.Exists(CaminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        if (i == 1) continue;
                        var usuarioArquivo = linha.Split(';');
                        var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
