using Application.IputPorts;
using Application.UseCases;
using Domain.Entities.Enums;
using Domain.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductUseCase _productUseCase;

        public ProductController(ILogger<ProductController> logger, IProductUseCase productUseCase)
        {
            _logger = logger;
            _productUseCase = productUseCase;
        }

        [HttpPost(Name = "PostProduct")]
        public async Task<IActionResult> Post([FromBody] ProdutoInput produto)
        {
            await _productUseCase.CreateProduct(produto);
            return Accepted();
        }

        [HttpGet(Name = "GetProduct")]
        public async Task<IActionResult> Get([FromQuery] Categoria categoria)
        {
            var products = await _productUseCase.GetProductsByCategory(categoria);

            if (products.IsNullOrEmpty())
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpPut(Name = "PutProduct")]
        public async Task<IActionResult> Put([FromBody] ProdutoInput produto, [FromQuery] Guid id)
        {
            await _productUseCase.UpdateProduct(produto, id);
            return Ok();
        }

        [HttpDelete(Name = "DeleteProduct")]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _productUseCase.DeleteProduct(id);
            return Ok();
        }
    }
}