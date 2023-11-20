namespace ECommerceLambda.Domain.Models
{
    public class Endereco
    {
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}
