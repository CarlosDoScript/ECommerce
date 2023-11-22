using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessarPedidoPago.Repositories
{
    public interface INotaFiscalRepository
    {
        Task SalvarNotaFiscal(NotaFiscal notaFiscal);
    }
}
