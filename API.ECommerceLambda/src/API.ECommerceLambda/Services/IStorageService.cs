namespace API.ECommerceLambda.Services
{
    public interface IStorageService
    {
        Task<byte[]> DownloadArquivo(string nomeBucket, string chaveArquivo);
    }
}
