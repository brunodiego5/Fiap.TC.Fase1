using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class Pedido
    {
        public Pedido(Cliente cliente, IList<ItemPedido> items)
        {
            Cliente = cliente;
            Number = Guid.NewGuid().ToString().Split("-")[0].ToUpper();
            DataCriacao = DateTime.Now;
            Status = Status.Criado;
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
