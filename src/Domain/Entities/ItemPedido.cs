using Domain.Base;

namespace Domain.Entities
{
    public class ItemPedido : IAggregateRoot
    {
        public ItemPedido(Produto produto, int quantidade, decimal preco)
        {
            Id = Guid.NewGuid();
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Guid Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco {  get; private set; }



    }
}
