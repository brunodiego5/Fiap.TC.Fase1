using Application.IputPorts;
using Domain.Entities;
using Domain.Producers;
using Domain.Repositories;

namespace Application.UseCases
{
    public class OrderUseCase : IOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;

        private readonly ICustomerRepository _customerRepository;

        private readonly IProductRepository _productRepository;

        private readonly IOrderProducerService _orderProducerService;

        public OrderUseCase(IOrderRepository orderRepository, 
            ICustomerRepository customerRepository, 
            IProductRepository productRepository, 
            IOrderProducerService orderProducerService)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _orderProducerService = orderProducerService;
        }

        public async Task Checkout(PedidoInput pedido)
        {
            Cliente cliente = await _customerRepository.GetCustomerById(new Guid(pedido.ClienteId));
            List<ItemPedido> itensPedido = new List<ItemPedido>();
            
            foreach (var item in pedido.Items)
            {
                Produto produto = await _productRepository.GetProductById(new Guid(item.ProdutoId));
                ItemPedido itemPedido = new ItemPedido(produto, item.Quantidade, produto.Preco);
                itensPedido.Add(itemPedido);
            }

            Pedido newPedido = new Pedido(cliente, itensPedido);

            await _orderRepository.Checkout(newPedido);

            _orderProducerService.PublishOrder(newPedido);
        }

        public async Task<IList<Pedido>> GetAllOrder()
        {
            return await _orderRepository.GetAllOrder();
        }
    }
}
