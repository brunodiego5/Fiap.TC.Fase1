using Domain.Entities;
using Domain.Repositories;
using Infra.Base;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class OrderRepository : Repository<Pedido>, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task Checkout(Pedido pedido)
        {
            await _collection.InsertOneAsync(pedido);
        }

        public async Task<IList<Pedido>> GetAllOrder()
        {
            var query = Builders<Pedido>.Filter.Empty;
            return await (await _collection.FindAsync(query)).ToListAsync();
        }
    }
}
