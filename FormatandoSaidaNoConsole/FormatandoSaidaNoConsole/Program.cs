using System;


namespace FormatandoSaidaNoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra*lucro);

            //{indice: 0, valor: 0.15, formatoReal: c  formatoPorcentagem: p}
            Console.WriteLine("Produto:.....:{0,15}", produto);
            Console.WriteLine("Val.Compra:..:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro:.......:{0,15:p}", lucro);
            Console.WriteLine("Vl.Venda:....:{0,15:c}", valorVenda);

            Console.ReadLine();
        }
    }
}
