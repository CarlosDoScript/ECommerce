using ECommerceLambda.Domain.Models;

namespace API.ECommerceLambda.Services
{
    public interface IPedidoService
    {
        Task EnviarPedido(Pedido pedido);
    }
}
