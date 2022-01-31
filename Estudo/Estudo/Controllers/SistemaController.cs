using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public static class SistemaController
    {
        
        public static char SouN()
        {
            char Op;
            Op = char.Parse(Console.ReadLine());
            
            if (Op == 'S' || Op == 's' || Op == 'N'|| Op == 'n'){
                return Op;
            } else
            {
                Console.WriteLine("\nOpção invalida!!! \n Digite 'S' para Sim ou 'N' para Não.");
                Op = '0';
                return Op;
            }
            
        }


        /*while(Op != 'N' || Op != 'n')
                    {
                        Console.WriteLine("\nDesculpa não entendi, informe 'S' para Sim ou 'N' para não!!!");
                        Console.WriteLine("\nDeseja cadastrar Outro Usuário (S/N)? ");
                        Op = char.Parse(Console.ReadLine());
                        if(Op == 'S')
                        break;
                    }
        */

}
}
