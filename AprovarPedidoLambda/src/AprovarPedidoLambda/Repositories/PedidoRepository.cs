using Amazon.DynamoDBv2.DataModel;
using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovarPedidoLambda.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IDynamoDBContext _contexto;
        public PedidoRepository(IDynamoDBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task SalvarPedido(Pedido pedido)
        {
            await _contexto.SaveAsync(pedido);
        }
    }
}
