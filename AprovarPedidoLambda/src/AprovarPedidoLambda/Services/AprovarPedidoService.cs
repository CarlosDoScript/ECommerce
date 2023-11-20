using AprovarPedidoLambda.Repositories;
using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovarPedidoLambda.Services
{
    public class AprovarPedidoService : IAprovarPedidoService
    {
        private readonly IPedidoRepository _repository;
        public AprovarPedidoService(IPedidoRepository repository)
        {
            _repository = repository;
            // repositorio
            // messageService
        }

        public async Task AprovarPedido(Pedido pedido)
        {
            await _repository.SalvarPedido(pedido);
        }
    }
}
