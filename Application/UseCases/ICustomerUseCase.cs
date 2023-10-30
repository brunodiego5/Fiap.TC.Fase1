using Domain.Entities;
using Domain.ValueObjects;

namespace Application.UseCases
{
    public interface ICustomerUseCase
    {
        Cliente CreateCustomer(Cliente cliente);

        Cliente GetCustomerByDocument(CPF cPF);
    }
}
