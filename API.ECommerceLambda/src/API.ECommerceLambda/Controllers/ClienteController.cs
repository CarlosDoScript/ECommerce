using API.ECommerceLambda.Models;
using API.ECommerceLambda.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.ECommerceLambda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteRepository _repository;

        public ClienteController(ILogger<ClienteController> logger, IClienteRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CriarCliente(Cliente cliente)
        {
            await _repository.Adicionar(cliente);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCliente(Cliente cliente)
        {
            await _repository.Atualizar(cliente);
            return Ok();
        }

        [HttpDelete("{documento}")]
        public async Task<IActionResult> DeletarCliente(string documento)
        {
            await _repository.Deletar(documento);
            return Ok();
        }

        [HttpGet("{documento}")]
        public async Task<IActionResult> ObterClientePorDocumento(string documento)
        {
            var cliente = await _repository.Buscar(documento);
            return Ok(cliente);
        }
    }
}
