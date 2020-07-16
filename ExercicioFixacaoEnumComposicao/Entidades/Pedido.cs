using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoEnumComposicao.Entidades.Enums;

namespace ExercicioFixacaoEnumComposicao.Entidades
{
    class Pedido
    {
       public DateTime Data { get; set; }
       public StatusDoPedido Status { get; set; }
       public Cliente Cliente { get; set; }
       public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
       
       public Pedido()
        {
        }

        public Pedido(DateTime data, StatusDoPedido status, Cliente cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
        }

        public void AddItens(ItemPedido item)
        {
            Itens.Add(item);
        }
        public void RemoveItens(ItemPedido item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double soma = 0.0;

            foreach ( ItemPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder resumo = new StringBuilder();
            resumo.AppendLine("Data do pedido: " + Data.ToString("dd/MM/aaaa HH:mm:ss"));
            resumo.AppendLine("Status do pedido: " + Status);
            resumo.AppendLine("Cliente: " + Cliente);
            resumo.AppendLine("Itens do pedido: ");
            foreach ( ItemPedido item in Itens)
            {
                resumo.AppendLine(item.ToString());
            }

            resumo.AppendLine("Preço total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return resumo.ToString();
        }
    }
}
