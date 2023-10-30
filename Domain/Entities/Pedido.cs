using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class Pedido
    {
        public Pedido(Cliente cliente, string number, DateTime dataCriacao, Status status, IList<ItemPedido> items)
        {
            Cliente = cliente;
            Number = number;
            DataCriacao = dataCriacao;
            Status = status;
            Items = items;
        }

        public Guid Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public string Number { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public Status Status { get; private set; }
        public IList<ItemPedido> Items { get; private set; }
    }
}
