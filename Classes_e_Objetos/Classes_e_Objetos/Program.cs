using System;

namespace Classes_e_Objetos
{
    internal class Program
    {
        static void Main()
        {
            /* ANNOTATIONS
             
            [ModificadorClasse] class NOME_DA_CLASSE{
                //variaveis/propriedades
                [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

                //Métodos
                [EspecificadorAcesso] retorno NOME_METODO([arg1, ...]){
                    //Corpo do método
                }
            }

            * ModificadorClasse: Define a visibilidade da classe
                - Public: Publica, sem restrição de visualização
                - Abstract: Classe base para outras classes, não podem ser instanciados objetos dessa classe
                - Selead: Classe não pode ser herdada
                - Static: A Classe não permite instaciação de objetos e seus membros devem ser Static

            * EspecificadorAcesso: Onde um membro da classe pode ser acessado
                - Public: Sem restrição de acesso
                - Private: Só pode ser acessado pela própria classe
                - Protected: Podem ser acessados na própria classe e nas clase derivadas
                - Abstract: Os métodos não tem implementação somente os cabeçalhos
                - Sealed: O método não pode ser redefinido
                - Virtual: O método pode ser redefinido em uma classe derivada
                - Static: O método pode ser chamado mesmo sem a instância de um objeto
            */

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50;
            Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

            Console.ReadLine();
        }

        public class Jogador
        {
            public int energia = 100;
            public bool vivo = true;
        }
    }
}
