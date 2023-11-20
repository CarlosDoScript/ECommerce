using Amazon.DynamoDBv2.DataModel;
using API.ECommerceLambda.Models;

namespace API.ECommerceLambda.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDynamoDBContext _contexto;

        public ClienteRepository(IDynamoDBContext contexto)
        {
            _contexto = contexto;
        }

        public Task Adicionar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente?> Buscar()
        {
            throw new NotImplementedException();
        }

        public Task Deletar(string documento)
        {
            throw new NotImplementedException();
        }
    }
}
