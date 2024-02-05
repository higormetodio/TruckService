using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckService.Models
{
    public abstract class PedidoModel
    {
        public cadastroClienteForm Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
    }
}
