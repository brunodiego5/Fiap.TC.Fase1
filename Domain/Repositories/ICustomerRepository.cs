using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories
{
    public interface ICustomerRepository
    {
        Cliente CreateCustomer(Cliente cliente);

        Cliente GetCustomerByDocument(CPF cPF);
    }
}
