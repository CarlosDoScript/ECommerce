using API.ECommerceLambda.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.ECommerceLambda.Controllers
{
    [Route("api/nota-fiscal")]
    [ApiController]
    public class NotaFiscalController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public NotaFiscalController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("download/{documento}/{ano}/{mes}/{dia}/{idNotaFiscal}")]
        public async Task<IActionResult> DownloadNotaFiscal(string documento, string ano, string mes, string dia, string idNotaFiscal)
        {
            var chaveArquivo = $"{documento}/{ano}/{mes}/{dia}/{idNotaFiscal}.json";
            var nomeArquivo = chaveArquivo.Replace("/","-");

            var objeto = await _storageService.DownloadArquivo("notas-emitidas-ecommerce-carlos-bucket", chaveArquivo);
    
            return File(objeto,"application/octet-stream",nomeArquivo);
        }
         
    }
}
