using Amazon.DynamoDBv2.DataModel;
using ECommerceLambda.Domain.Models;

namespace API.ECommerceLambda.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDynamoDBContext _contexto;

        public ClienteRepository(IDynamoDBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task Adicionar(Cliente cliente)
        {
            await _contexto.SaveAsync<Cliente>(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            await _contexto.SaveAsync<Cliente>(cliente);
        }

        public async Task<Cliente?> Buscar(string documento)
        {
            return await _contexto.LoadAsync<Cliente?>(documento);
        }

        public async Task Deletar(string documento)
        {
            await _contexto.DeleteAsync<Cliente>(documento);
        }
    }
}
