using ECommerceLambda.Domain.Models;
using ProcessarPedidoPago.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProcessarPedidoPago.Services
{
    public class ProcessarPedidoPago : IProcessarPedidoPago
    {
        private readonly IStorageService _storage;
        private readonly INotaFiscalRepository _notaFiscalRepository;

        public ProcessarPedidoPago(IStorageService storage, INotaFiscalRepository notaFiscalRepository)
        {
            _storage = storage;
            _notaFiscalRepository = notaFiscalRepository;
        }

        public async Task Processar(Pedido pedido)
        {            
            var notaFiscal = new NotaFiscal
            {
                DocumentoCliente = pedido.DocumentoCliente,
                IdNotaFiscal = Guid.NewGuid().ToString(),
                BaseDeCalculo = pedido.ValorTotal,
                AliquotaTributo = 20,
                Descricao = $"Nota Fiscal relativa ao pedido {pedido.PedidoId}"
            };

            await _storage.SalvarNotaFiscal(notaFiscal);
            await _notaFiscalRepository.SalvarNotaFiscal(notaFiscal);
        }
    }
}
