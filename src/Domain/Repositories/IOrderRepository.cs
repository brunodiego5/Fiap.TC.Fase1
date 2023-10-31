using Domain.Base;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IOrderRepository : IRepository
    {
        Task Checkout(Pedido pedido);

        Task<IList<Pedido>> GetAllOrder();
    }
}
