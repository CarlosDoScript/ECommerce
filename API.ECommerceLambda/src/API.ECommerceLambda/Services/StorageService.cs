using Amazon.S3;
using Amazon.S3.Model;

namespace API.ECommerceLambda.Services
{
    public class StorageService : IStorageService
    {
        private readonly IAmazonS3 _clientS3;

        public StorageService(IAmazonS3 clientS3)
        {
            _clientS3 = clientS3;
        }

        public async Task<byte[]> DownloadArquivo(string nomeBucket, string chaveArquivo)
        {
            MemoryStream? stream = null;

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = nomeBucket,
                Key = chaveArquivo
            };

            var resposta = await _clientS3.GetObjectAsync(getObjectRequest);

            if (resposta.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                stream = new MemoryStream();
                await resposta.ResponseStream.CopyToAsync(stream);
            }

            if (stream is null)
            {
                throw new FileNotFoundException($"O arquivo {chaveArquivo} não foi localizado.");
            }

            return stream.ToArray();
        }
    }
}
