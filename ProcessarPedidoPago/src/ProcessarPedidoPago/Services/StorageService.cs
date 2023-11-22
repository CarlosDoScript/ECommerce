using Amazon.S3;
using Amazon.S3.Model;
using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProcessarPedidoPago.Services
{
    public class StorageService : IStorageService
    {
        private readonly IAmazonS3 _client;

        public StorageService(IAmazonS3 client)
        {
            _client = client;
        }

        public async Task SalvarNotaFiscal(NotaFiscal notaFiscal)
        {
            var prefixo = $"{notaFiscal.DocumentoCliente}/{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}";
            var key = $"{prefixo}/{Guid.NewGuid()}.json";

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "notas-emitidas-ecommerce-carlos-bucket",
                Key = key,
                ContentType = "application/json",
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(notaFiscal)))
            };

            await _client.PutObjectAsync(putObjectRequest);
        }
    }
}
