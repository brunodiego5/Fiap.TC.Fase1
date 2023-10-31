using Domain.Base;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICustomerRepository : IRepository
    {
        Task CreateCustomer(Cliente cliente);

        Task<Cliente> GetCustomerByDocument(string cpf);

        Task<Cliente> GetCustomerById(Guid id);
    }
}
