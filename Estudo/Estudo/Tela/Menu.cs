using System;
using Estudo.Controllers;
using Sistema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tela
{
    public class Menu
    {
        
        internal static void MenuEscolha()
        {

            char escolha ;

            Console.WriteLine("--------------------------------- Menu ----------------------------------");
            Console.WriteLine("\nEscolha uma das Opções a baixo: ");
            Console.WriteLine(
                " 1 - Usuário" +
                "\n 2 - teste"
                );
            escolha = char.Parse(Console.ReadLine());

            char Op;

;           do
            {
                switch (escolha)
                {

                    //Menu Principal
                    case '1':
                        Console.WriteLine("\n------------------ Usuario ------------------");
                        Console.WriteLine("Escolha uma das Opções: ");
                        Console.WriteLine(
                            "\n1 - Cadastrar Usuário" +
                            "\n2 - Listar todos os Usuários"
                            );
                        char op = char.Parse(Console.ReadLine());

                        //Menu Usuário
                        switch (op)
                        {
                            case '1':
                                Console.WriteLine("------------------- Cadastrar Usuários ------------------");
                                UsuarioController.Cadastro();
                                break;
                            case '2':
                                Console.WriteLine("------------------- Listar Usuários ------------------");
                                UsuarioController.ListarUsuarios();
                                break;
                        }
                        break;


                    case '2':

                        break;



                }

                Console.WriteLine("\nDeseja Retornar ao Menu de Usuário(S/N)? ");
                do 
                { 
                    Op = SistemaController.SouN();
                } while (Op == '0');

            } while (Op == 'S' || Op == 's');
        }
            


    }
}
