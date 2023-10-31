using Domain.Base;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Cliente : IAggregateRoot
    {
        public Cliente(string nome, string email, CPF cPF)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            CPF = cPF;

            ValidateEntity();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public CPF CPF { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Email, "O email não pode estar vazio!");
        }
    }
}
