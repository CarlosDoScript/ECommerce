using ECommerceLambda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessarPedidoPago.Services
{
    public interface IStorageService
    {
        Task SalvarNotaFiscal(NotaFiscal notaFiscal);
    }
}
