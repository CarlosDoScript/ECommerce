using API.ECommerceLambda.Models;

namespace API.ECommerceLambda.Repositories
{
    public interface IClienteRepository
    {
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task<Cliente?> Buscar();
        Task Deletar(string documento);
    }
}
