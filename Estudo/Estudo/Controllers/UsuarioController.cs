using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using usuario;


namespace Estudo.Controllers
{
    public class UsuarioController : Usuario
    {
        //Mátris de Usuário
        static string[,] usuario = new string[QtdUsuarios, QtdInformacoes];
        static string[] usuario2 = new string[QtdInformacoes];

        //Cadastrar Usuario
        public static void Cadastro()
        {
            char Op;
            int i = 0;
            QtdUsuarios = 0;

            for (int k = 0; k <= QtdUsuarios; k++)
            {

                if(k == 0)
                {
                    Console.WriteLine("\nInforme seu Nome: ");
                    usuario2[k] = Console.ReadLine();
                    QtdUsuarios++;
                } else if (k == 1)
                {
                    Console.WriteLine("\nInforme seu E-mail: ");
                    usuario2[k] = Console.ReadLine();
                    QtdUsuarios++;
                } else if (k == 2)
                {
                    Console.WriteLine("\nInforme sua Senha: ");
                    usuario2[k] = Console.ReadLine();
                    QtdUsuarios++;
                }
               
                
            }

            /*while (i < 5)
            {
                Console.WriteLine(QtdUsuarios);
                //do
                //{
                    for (int j = 0; j < QtdInformacoes; j++)
                    {
                        QtdUsuarios++;
                        if (j == 0)
                        {
                            Console.WriteLine("\nInforme seu Nome: ");
                            usuario[i, j] = Console.ReadLine();
                        }
                        else if (j == 1)
                        {
                            Console.WriteLine("\nInforme seu E-mail: ");
                            usuario[i, j] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nInforme sua Senha: ");
                            usuario[i, j] = Console.ReadLine();
                        }
                    }
                    //Carregar a variável i
                    i++;
                    
                    /*Console.WriteLine("\nDeseja cadastrar Outro Usuário (S/N)? ");
                    do
                    {
                        //Método de tratamento de exceção 
                        Op = SistemaController.SouN();
                    } while (Op == '0');
                }while(Op == 'S' || Op == 's');*
            }*/
            

                

            
        }

        //Listar Usuarios
        public static void ListarUsuarios()
        {
            /*for (int i = 0; i < Usuario.QtdUsuarios; i++)
            {
                Console.WriteLine("\nUsuario{0} ", i);
                for ( int j = 0; j < Usuario.QtdInformacoes; j++)
                {
                    Console.WriteLine(usuario[ i, j ]);

                }
            }*/

            foreach (string usuarios in usuario)
            {
                Console.WriteLine(usuarios);
            }

           

            Console.ReadLine();
        }

    }
}
