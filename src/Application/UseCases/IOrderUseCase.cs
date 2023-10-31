using Application.IputPorts;
using Domain.Entities;

namespace Application.UseCases
{
    public interface IOrderUseCase
    {
        Task Checkout(PedidoInput pedido);

        Task<IList<Pedido>> GetAllOrder();
    }
}
