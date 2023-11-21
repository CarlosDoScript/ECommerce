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
        private readonly IMessageService _messageService;
        public AprovarPedidoService(IPedidoRepository repository, IMessageService messageService)
        {
            _repository = repository;
            _messageService = messageService;
        }

        public async Task AprovarPedido(Pedido pedido)
        {
            if (pedido == null)
            {
                throw new Exception("Pedido é de preenchimento obrigatório.");
            }

            if (pedido.Cliente == null)
            {
                throw new Exception("Cliente é de preenchimento obrigatório.");
            }

            if (pedido.Cliente.Endereco == null)
            {
                throw new Exception("Endereco é de preenchimento obrigatório.");
            }

            //tentaiva de pagamento no gateway 

            pedido.StatusPedido = StatusPedidoEnum.AGUARDANDO_ENVIO;

            await _repository.SalvarPedido(pedido);
            await _messageService.SendMessage(pedido);
        }
    }
}
