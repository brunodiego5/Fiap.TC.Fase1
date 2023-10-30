using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class OrderUseCase : IOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Pedido Checkout(Pedido pedido)
        {
            return _orderRepository.Checkout(pedido);
        }

        public IList<Pedido> GetAllOrder()
        {
            return _orderRepository.GetAllOrder();
        }
    }
}
