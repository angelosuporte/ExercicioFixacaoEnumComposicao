using ExercicioFixacaoEnumComposicao.Entidades;

namespace ExercicioFixacaoEnumComposicao.Entidades
{
    class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        

        public ItemPedido()
        {
        }

        public ItemPedido(Produto produto, int quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double subTotal(double subtotal)
        {
            return Quantidade * Preco;
        }
    }
}
