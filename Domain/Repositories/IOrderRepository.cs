using Domain.Entities;

namespace Domain.Repositories
{
    public interface IOrderRepository
    {
        Pedido Checkout(Pedido pedido);

        IList<Pedido> GetAllOrder();
    }
}
