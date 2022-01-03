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
            //Menu.Criar();
            var clientes = Cliente.lerClientes();

            /*var cliente = new Cliente();
            cliente.Nome = "Jow";
            cliente.Telefone = "90907070";
            cliente.Cpf = "12345678";
            cliente.Gravar();

            var cliente2 = new Cliente();
            cliente.Nome = "Davi";
            cliente.Telefone = "9999990111";
            cliente.Cpf = "987654321";
            cliente2.Gravar();*/

            Console.ReadLine();
        }

    }
}
