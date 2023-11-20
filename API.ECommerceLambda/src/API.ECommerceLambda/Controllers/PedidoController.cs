using API.ECommerceLambda.Models;
using API.ECommerceLambda.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.ECommerceLambda.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly IPedidoService _service;

        public PedidoController(ILogger<PedidoController> logger, IPedidoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPedido(Pedido pedido)
        {
            _logger.LogInformation("Enviando o pedido para a fila.");

            await _service.EnviarPedido(pedido);

            return Ok();
        }
    }
}
