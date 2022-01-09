using System;
using Classes;
using Tela;

// *Ir no App.config -> <appSeting><add. key="" value="">.
// *Ir no Reference -> Bt direito -> adicionar referencia -> Framework -> abilitar systen.configuration (vai nos dar a opção de ler o nosso webConfig)

namespace Programacao_Orientada_A_Funcao
{
    internal class Program
    {
        static void Main()
        {
           // Menu.Criar();

            /*var clienteT = new Cliente();
            Console.WriteLine("informe o Nome: ");
            clienteT.Nome = Console.ReadLine();
            Console.WriteLine("informe o Telefone: ");
            clienteT.Telefone = Console.ReadLine();
            Console.WriteLine("informe o CPF: ");
            clienteT.Cpf = Console.ReadLine();
            clienteT.Gravar();*/

            var cliente = new Cliente();
            cliente.Nome = "Teste1";
            cliente.Telefone = "90907070";
            cliente.Cpf = "12345678";
            cliente.Gravar();

           

            //Mostrar todos os clientes
            var clientes = Cliente.lerClientes();
            foreach(Cliente c in clientes)
            {
                Console.WriteLine(c.Nome + " - Fone: " + c.Telefone + " Cpf: " + c.Cpf );
                Console.WriteLine("================================================================");
            }


            Console.ReadLine();
        }

    }
}
