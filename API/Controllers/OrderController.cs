using Application.IputPorts;
using Application.UseCases;
using Domain.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderUseCase _orderUseCase;

        public OrderController(ILogger<OrderController> logger, IOrderUseCase orderUseCase)
        {
            _logger = logger;
            _orderUseCase = orderUseCase;
        }

        [HttpPost(Name = "PostOrder")]
        public async Task<IActionResult> Post([FromBody] PedidoInput pedido)
        {
            await _orderUseCase.Checkout(pedido);
            return Ok();
        }

        [HttpGet(Name = "GetAllOrder")]
        public async Task<IActionResult> Get()
        {
            var orders = await _orderUseCase.GetAllOrder();

            if (orders.IsNullOrEmpty())
            {
                return NotFound();
            }

            return Ok(orders);
        }        
    }
}