using Domain.Entities;

namespace Application.UseCases
{
    public interface IOrderUseCase
    {
        Pedido Checkout(Pedido pedido);

        IList<Pedido> GetAllOrder();
    }
}
