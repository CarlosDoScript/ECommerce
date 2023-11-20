namespace API.ECommerceLambda.Models
{
    public class Cliente
    {
        public string? Documento { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Endereco? Enderecp {  get; set; }
    }
}
