using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Application.UseCases
{
    public class CustomerUseCase : ICustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerUseCase(ICustomerRepository userRepository)
        {
            _customerRepository = userRepository;
        }

        public async Task CreateCustomer(Cliente cliente)
        {
            await _customerRepository.CreateCustomer(cliente);
        }

        public async Task<Cliente> GetCustomerByDocument(CPF cPF)
        {
            return await _customerRepository.GetCustomerByDocument(cPF);
        }
    }
}
