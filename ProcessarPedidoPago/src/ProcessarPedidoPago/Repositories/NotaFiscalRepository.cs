using Amazon.DynamoDBv2.DataModel;
using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessarPedidoPago.Repositories
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private IDynamoDBContext _context;

        public NotaFiscalRepository(IDynamoDBContext context)
        {
            _context = context;
        }
        public async Task SalvarNotaFiscal(NotaFiscal notaFiscal)
        {
            await _context.SaveAsync(notaFiscal);
        }
    }
}
