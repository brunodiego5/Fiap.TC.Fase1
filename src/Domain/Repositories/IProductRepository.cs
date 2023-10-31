using Domain.Base;
using Domain.Entities;
using Domain.Entities.Enums;

namespace Domain.Repositories
{
    public interface IProductRepository : IRepository
    {
        Task CreateProduct(Produto produto);

        Task UpdateProduct(Produto produto, Guid id);

        Task DeleteProduct(Guid id);

        Task<IList<Produto>> GetProductsByCategory(Categoria categoria);

        Task<Produto> GetProductById(Guid id);
    }
}
