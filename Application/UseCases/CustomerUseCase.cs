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

        public Cliente CreateCustomer(Cliente cliente)
        {
            return _customerRepository.CreateCustomer(cliente);
        }

        public Cliente GetCustomerByDocument(CPF cPF)
        {
            return _customerRepository.GetCustomerByDocument(cPF);
        }
    }
}
