using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceLambda.Domain.Models
{
    public class NotaFiscal
    {
        public string DocumentoCliente { get; set; }
        public Guid IdNotaFiscal { get; set; }
        public decimal BaseDeCalculo { get; set; }
        public decimal AliquotaTributo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorTributo {

            get 
            {
                return BaseDeCalculo * AliquotaTributo / 100;
            }
            set
            {
                ValorTributo = value;
            }
        }
    }
}
