using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("           Aplicativo Sistema Comercial");
            Console.WriteLine("==============================================");

            Console.Write("\nInforme o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("\nInforme o telefone do cliente: ");
            string telefoneCliente = Console.ReadLine();
            Console.Write("\nInforme o produto a ser cadastrado: ");
            string nome = Console.ReadLine();
            Console.Write("\nInforme o valor do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nInforme a quantidade do produto: ");
            int qte = int.Parse(Console.ReadLine());


            Produto produto = new Produto(nome, preco, qte);
            Cliente cliente = new Cliente(nomeCliente, telefoneCliente);


            Console.WriteLine("\nNome do cliente: "
                + cliente.Nome
                + "\nTelefone do cliente: "
                + cliente.Telefone
                + produto);

            Console.Write("\nInforme a quantidade de produtos vendidos: ");
            int vendidos = int.Parse(Console.ReadLine());
            produto.RemoverProduto(vendidos);

            Console.WriteLine(produto);



        }
    }
}
