using Amazon.SQS;
using Amazon.SQS.Model;
using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AprovarPedidoLambda.Services
{
    public class MessageService : IMessageService
    {
        private readonly IAmazonSQS _sqsClient;
        public MessageService(IAmazonSQS SqsClient)
        {
            _sqsClient = SqsClient;
        }

        public async Task SendMessage(Pedido pedido)
        {
            var request = new SendMessageRequest
            {
                MessageBody = JsonSerializer.Serialize(pedido),
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/329122080951/pedido-pago-sqs"
            };

            await _sqsClient.SendMessageAsync(request);

        }
    }
}
