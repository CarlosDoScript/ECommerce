using Amazon.DynamoDBv2.DataModel;

namespace API.ECommerceLambda.Models
{
    [DynamoDBTable("Cliente")]
    public class Cliente
    {
        [DynamoDBHashKey("Documento")]
        public string? Documento { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Endereco? Endereco {  get; set; }
    }
}
