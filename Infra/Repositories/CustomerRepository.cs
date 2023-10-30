using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IMongoCollection<Cliente> _collection;

        public CustomerRepository(IMongoClient client, string databaseName, string collectionName)
        {
            _collection = client.GetDatabase(databaseName).GetCollection<Cliente>(collectionName);
        }


        public async Task CreateCustomer(Cliente cliente)
        {
            await _collection.InsertOneAsync(cliente);

        }

        public async Task<Cliente> GetCustomerByDocument(CPF cPF)
        {
            return await _collection.Find(filter => filter.CPF.Numero == cPF.Numero).FirstOrDefaultAsync();
        }
    }
}
