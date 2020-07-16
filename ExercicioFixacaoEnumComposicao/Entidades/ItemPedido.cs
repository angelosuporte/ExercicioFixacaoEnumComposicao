using ExercicioFixacaoEnumComposicao.Entidades;

namespace ExercicioFixacaoEnumComposicao.Entidades
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
