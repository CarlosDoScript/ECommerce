namespace API.ECommerceLambda.Models
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int ProdutoId { get; set; }
    }
}
