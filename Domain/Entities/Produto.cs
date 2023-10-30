using Domain.Base;
using Domain.Entities.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Produto : IAggregateRoot
    {
        public Produto(string nome, Categoria categoria, decimal preco, string descricao, IList<string> imagens)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Descricao = descricao;
            Imagens = imagens;

            ValidateEntity();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public IList<string> Imagens { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Descricao, "A descricao não pode estar vazio!");
        }
    }
}
