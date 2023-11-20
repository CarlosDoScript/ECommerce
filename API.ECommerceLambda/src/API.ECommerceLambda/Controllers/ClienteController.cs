using API.ECommerceLambda.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.ECommerceLambda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CriarCliente(Cliente cliente)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCliente(Cliente cliente)
        {
            return Ok();
        }

        [HttpDelete("{documento}")]
        public async Task<IActionResult> DeletarCliente(string documento)
        {
            return Ok();
        }

        [HttpGet("{documento}")]
        public async Task<IActionResult> ObterClientePorDocumento(string documento)
        {
            return Ok();
        }
    }
}
