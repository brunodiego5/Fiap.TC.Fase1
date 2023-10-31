using Domain.Base;

namespace Domain.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Numero;
        }
    }
}
