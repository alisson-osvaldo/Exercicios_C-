using System;
using Tela;

// *Ir no App.config -> <appSeting><add. key="" value="">.
// *Ir no Reference -> Bt direito -> adicionar referencia -> Framework -> abilitar systen.configuration (vai nos dar a opção de ler o nosso webConfig)

namespace Programacao_Orientada_A_Funcao
{
    class Program
    {
        static void Main()
        {
            //Menu.Criar();
            
            Classes.Usuario u = new Classes.Usuario();
            u.Nome = "Usuario teste 2";
            u.Cpf = "123456";
            u.Telefone = "90909090";
            u.Gravar();

            foreach(Classes.Usuario user in Classes.Usuario.lerUsuarios())
            {
                Console.WriteLine(user.Nome);
                Console.WriteLine(user.Cpf);
                Console.WriteLine(user.Telefone);
                Console.WriteLine("============================");
            }


            Classes.Cliente c = new Classes.Cliente();
            c.Nome = "Cliente";
            c.Cpf = "00000000";
            c.Telefone = "90901010";
            c.Gravar();

            foreach (Classes.Cliente cli in Classes.Cliente.lerClientes())
            {
                Console.WriteLine(cli.Nome);
                Console.WriteLine(cli.Cpf);
                Console.WriteLine(cli.Telefone);
                Console.WriteLine("============================");
            }



        }

    }
}
