using Domain.Base;
using Domain.Entities.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Produto : IAggregateRoot
    {
        public Produto(Guid id, string nome, Categoria categoria, decimal preco, string descricao, string imagem)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Descricao = descricao;
            Imagem = imagem;

            ValidateEntity();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Descricao, "A descricao não pode estar vazio!");
        }
    }
}
