using Domain.Entities;
using Domain.Entities.Enums;

namespace Application.UseCases
{
    public interface IProductUseCase
    {
        Produto CreateProduct(Produto produto);

        Produto UpdateProduct(Produto produto);

        void DeleteProduct(Guid id);

        IList<Produto> GetProductsByCategory(Categoria categoria);
    }
}
