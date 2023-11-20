using Amazon.SQS;
using Amazon.SQS.Model;
using API.ECommerceLambda.Models;
using System.Text.Json;

namespace API.ECommerceLambda.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IAmazonSQS _sqsCliente;
        public PedidoService(IAmazonSQS sqsClient)
        {
            _sqsCliente = sqsClient;
        }
        public async Task EnviarPedido(Pedido pedido)
        {
            var request = new SendMessageRequest
            {
                MessageBody = JsonSerializer.Serialize(pedido),
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/329122080951/pedido-criado-sqs"
            };

            await _sqsCliente.SendMessageAsync(request);
        }
    }
}
