using Domain.Entities;
using Domain.Entities.Enums;

namespace Domain.Repositories
{
    public interface IProductRepository
    {
        Produto CreateProduct(Produto produto);

        Produto UpdateProduct(Produto produto);

        void DeleteProduct(Guid id);

        IList<Produto> GetProductsByCategory(Categoria categoria);
    }
}
