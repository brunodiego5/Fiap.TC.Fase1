using Domain.Entities;
using Domain.ValueObjects;

namespace Application.UseCases
{
    public interface ICustomerUseCase
    {
        Task CreateCustomer(Cliente cliente);

        Task<Cliente> GetCustomerByDocument(CPF cPF);
    }
}
