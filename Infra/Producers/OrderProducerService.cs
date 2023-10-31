using Domain.Entities;
using Domain.Producers;

namespace Infra.Producers
{
    public class OrderProducerService : IOrderProducerService
    {
        public void PublishOrder(Pedido pedido)
        {
            Console.Write($"Pedido: {pedido.Number} enviado para fila.");
        }
    }
}
