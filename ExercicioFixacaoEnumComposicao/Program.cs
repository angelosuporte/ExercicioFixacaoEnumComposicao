using System;
using System.Globalization;
using ExercicioFixacaoEnumComposicao.Entidades;
using ExercicioFixacaoEnumComposicao.Entidades.Enums;

namespace ExercicioFixacaoEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dos dados do cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe dos dados do pedido: ");
            Console.Write("Status: ");
            StatusDoPedido status = Enum.Parse<StatusDoPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);


            Console.Write("Quantos itens para este pedido? ");
            int nItem = int.Parse(Console.ReadLine()); //Itens diferentes

            for (int i = 1; i <= nItem; i++)
            {
                Console.WriteLine($"Informe os dados do item #{i}");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine()); //Quantidade de cada item

                ItemPedido itemPedido = new ItemPedido(quantidade, preco, produto);

                pedido.AddItens(itemPedido);

            }
            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO");
            Console.WriteLine(pedido);




        }
    }
}
