using System;
using Classes;

namespace Funcoes
{
    internal class TelaCliente
    {

        public static void Chamar() {

            Console.WriteLine("============================== Cadastrar Cliente ================================");

            while (true)
            {

                //Menu Cliente
                string msg = "\n\nEscolha uma das Opções a baixo:" +
                "\n 0 - Sair do Cadastro" +
                "\n 1 - Cadastrar Clientes" +
                "\n 2 - Listar Clientes";

                Console.WriteLine(msg);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {

                    var clienteT = new Cliente();
                    Console.WriteLine("informe o Nome: ");
                    clienteT.Nome = Console.ReadLine();
                    Console.WriteLine("informe o Telefone: ");
                    clienteT.Telefone = Console.ReadLine();
                    Console.WriteLine("informe o CPF: ");
                    clienteT.Cpf = Console.ReadLine();
                    clienteT.Gravar();

                }
                else
                {

                    //Listar Clientes
                    var clientes = Cliente.lerClientes();
                    Console.WriteLine("\n============================ Lista de Clientes =============================");
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome + " - Fone: " + c.Telefone + " Cpf: " + c.Cpf);
                        Console.WriteLine("================================================================");
                    }

                }
            }

           
     
        }

    }
}
