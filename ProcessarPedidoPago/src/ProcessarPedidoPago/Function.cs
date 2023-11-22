using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Amazon.S3;
using ECommerceLambda.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using ProcessarPedidoPago.Repositories;
using ProcessarPedidoPago.Services;
using System.Security.Authentication.ExtendedProtection;
using System.Text.Json;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ProcessarPedidoPago
{
    public class Function
    {
        private IProcessarPedidoPago _processarPedidoPago;

        /// <summary>
        /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
        /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
        /// region the Lambda function is executed in.
        /// </summary>
        public Function()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IAmazonS3, AmazonS3Client>();
            serviceCollection.AddScoped<IAmazonDynamoDB, AmazonDynamoDBClient>();
            serviceCollection.AddScoped<IDynamoDBContext, DynamoDBContext>();
            serviceCollection.AddScoped<IProcessarPedidoPago, Services.ProcessarPedidoPago>();
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            _processarPedidoPago = serviceProvider.GetRequiredService<IProcessarPedidoPago>();
        }


        /// <summary>
        /// This method is called for every Lambda invocation. This method takes in an SQS event object and can be used 
        /// to respond to SQS messages.
        /// </summary>
        /// <param name="evnt"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task FunctionHandler(SQSEvent evnt, ILambdaContext context)
        {
            foreach (var message in evnt.Records)
            {
                await ProcessMessageAsync(message, context);
            }
        }

        private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
        {
            context.Logger.LogInformation($"Processed message {message.Body}");

            var pedido = JsonSerializer.Deserialize<Pedido>(message.Body);

            await _processarPedidoPago.Processar(pedido);

            await Task.CompletedTask;
        }
    }
}