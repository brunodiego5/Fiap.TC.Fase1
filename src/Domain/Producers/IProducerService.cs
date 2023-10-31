using Domain.Entities;

namespace Domain.Producers
{
    public interface IOrderProducerService
    {
        void PublishOrder(Pedido pedido);
    }
}
