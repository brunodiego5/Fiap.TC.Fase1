namespace Application.IputPorts
{
    public class PedidoInput
    {
        public PedidoInput(string clienteId, IList<ItemPedidoInput> items)
        {
            ClienteId = clienteId;
            Items = items;
        }

        public string ClienteId { get; private set; }
        public IList<ItemPedidoInput> Items { get; private set; }
    }
}
