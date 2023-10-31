using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Repositories;
using Infra.Base;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infra.Repositories
{
    public class ProductRepository : Repository<Produto>, IProductRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task CreateProduct(Produto produto)
        {
            await _collection.InsertOneAsync(produto);
        }

        public async Task DeleteProduct(Guid id)
        {
            var query = Builders<Produto>.Filter.Where(r => r.Id == id);
            await _collection.DeleteOneAsync(query);
        }

        public async Task<IList<Produto>> GetProductsByCategory(Categoria categoria)
        {
            var query = Builders<Produto>.Filter.Where(r => r.Categoria == categoria);
            return await (await _collection.FindAsync(query)).ToListAsync();
        }

        public async Task UpdateProduct(Produto produto, Guid id)
        {
            var query = Builders<Produto>.Filter.Where(r => r.Id == id);
            await _collection.ReplaceOneAsync(query, produto);
        }

        public async Task<Produto> GetProductById(Guid id)
        {
            return await _collection.Find(filter => filter.Id == id).FirstOrDefaultAsync();
        }
    }
}
