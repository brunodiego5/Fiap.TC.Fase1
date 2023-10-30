using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task CreateCustomer(Cliente cliente);

        Task<Cliente> GetCustomerByDocument(CPF cPF);
    }
}
