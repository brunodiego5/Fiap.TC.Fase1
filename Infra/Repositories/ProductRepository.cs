using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Repositories;
using Domain.ValueObjects;

namespace Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Produto CreateProduct(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> GetProductsByCategory(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Produto UpdateProduct(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
