using Application.IputPorts;
using Domain.Entities;
using Domain.Entities.Enums;

namespace Application.UseCases
{
    public interface IProductUseCase
    {
        Task CreateProduct(ProdutoInput produto);

        Task UpdateProduct(ProdutoInput produto, Guid id);

        Task DeleteProduct(Guid id);

        Task<IList<Produto>> GetProductsByCategory(Categoria categoria);
    }
}
