using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerUseCase _customerUseCase;

        public CustomerController(ILogger<CustomerController> logger, ICustomerUseCase customerUseCase)
        {
            _logger = logger;
            _customerUseCase = customerUseCase;
        }

        [HttpPost(Name = "PostCustomer")]
        public async Task<IActionResult> Post([FromBody] Cliente cliente)
        {
            await _customerUseCase.CreateCustomer(cliente);
            return Accepted();
        }

        [HttpGet(Name = "GetCustomer")]
        public async Task<IActionResult> Get([FromQuery] string cpf)
        {
            var customer = await _customerUseCase.GetCustomerByDocument(cpf);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }
    }
}