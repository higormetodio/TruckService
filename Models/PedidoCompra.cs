using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckService.Models
{
    public class PedidoCompra
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public bool Pagamento { get; set; }
    }
}
