using API.ECommerceLambda.Models;

namespace API.ECommerceLambda.Services
{
    public interface IPedidoService
    {
        Task EnviarPedido(Pedido pedido);
    }
}
