using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovarPedidoLambda.Repositories
{
    public interface IPedidoRepository
    {
        Task SalvarPedido(Pedido pedido);
    }
}
