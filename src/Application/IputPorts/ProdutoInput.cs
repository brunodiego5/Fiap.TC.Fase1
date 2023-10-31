using Domain.Entities.Enums;

namespace Application.IputPorts
{
    public class ProdutoInput
    {
        public ProdutoInput(string nome, Categoria categoria, decimal preco, string descricao, string imagem)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Descricao = descricao;
            Imagem = imagem;
        }

        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }
    }
}
