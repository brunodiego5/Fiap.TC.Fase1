namespace Application.IputPorts
{
    public class ItemPedidoInput
    {
        public ItemPedidoInput(string produtoId, int quantidade)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public string ProdutoId { get; private set; }
        public int Quantidade { get; private set; }



    }
}
