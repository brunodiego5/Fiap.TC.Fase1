using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Repositories;

namespace Application.UseCases
{
    public class ProductUseCase : IProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public ProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Produto CreateProduct(Produto produto)
        {
            return _productRepository.CreateProduct(produto);
        }

        public void DeleteProduct(Guid id)
        {
            _productRepository.DeleteProduct(id);
        }

        public IList<Produto> GetProductsByCategory(Categoria categoria)
        {
            return _productRepository.GetProductsByCategory(categoria);
        }

        public Produto UpdateProduct(Produto produto)
        {
            return _productRepository.UpdateProduct(produto);
        }
    }
}
