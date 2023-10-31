using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Infra.Base;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class CustomerRepository : Repository<Cliente>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration) : base(configuration)
        {
        }


        public async Task CreateCustomer(Cliente cliente)
        {
            await _collection.InsertOneAsync(cliente);

        }

        public async Task<Cliente> GetCustomerByDocument(string cpf)
        {
            return await _collection.Find(filter => filter.CPF.Numero == cpf).FirstOrDefaultAsync();
        }

        public async Task<Cliente> GetCustomerById(Guid id)
        {
            return await _collection.Find(filter => filter.Id == id).FirstOrDefaultAsync();
        }
    }
}
