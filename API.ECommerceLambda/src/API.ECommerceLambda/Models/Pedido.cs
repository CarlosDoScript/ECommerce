namespace API.ECommerceLambda.Models
{
    public class Pedido
    {
        public StatusPedidoEnum StatusPedido { get; set; }
        public Guid PedidoId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal => ItensPedido.Sum(x => x.ValorUnitario * x.Quantidade);
        public List<ItemPedido> ItensPedido { get; set; }
    }
}
