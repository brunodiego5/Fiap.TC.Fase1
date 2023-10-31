using Application.IputPorts;
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

        public async Task CreateProduct(ProdutoInput produtoInput)
        {

            await _productRepository.CreateProduct(
                new Produto(
                    Guid.NewGuid(),
                    produtoInput.Nome,
                    produtoInput.Categoria, 
                    produtoInput.Preco, 
                    produtoInput.Descricao, 
                    produtoInput.Imagem));
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productRepository.DeleteProduct(id);
        }

        public async Task<IList<Produto>> GetProductsByCategory(Categoria categoria)
        {
            return await _productRepository.GetProductsByCategory(categoria);
        }

        public async Task UpdateProduct(ProdutoInput produtoInput, Guid id)
        {
            await _productRepository.UpdateProduct(new Produto(
                    id,
                    produtoInput.Nome,
                    produtoInput.Categoria,
                    produtoInput.Preco,
                    produtoInput.Descricao,
                    produtoInput.Imagem), id);
        }
    }
}
