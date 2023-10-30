using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Pedido Checkout(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> GetAllOrder()
        {
            throw new NotImplementedException();
        }
    }
}
