using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AprovarPedidoLambda
{
    public class Function
    {
        public async Task FunctionHandler(SQSEvent input, ILambdaContext context)
        {
            foreach (var message in input.Records)
            {
                await ProcessarMensagem(message,context);
            }
        }

        private async Task ProcessarMensagem(SQSEvent.SQSMessage message, ILambdaContext context)
        {
            context.Logger.Log("Mesagem processada");
            context.Logger.Log(message.Body);

            await Task.CompletedTask;
        }
    }
}
