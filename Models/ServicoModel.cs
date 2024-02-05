using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckService.Models
{
    public abstract class ServicoModel
    {
        public cadastroClienteForm? Cliente { get; set; }
        public string? Veiculo { get; set; }
        public string? Placa { get; set; }
        public List<Servico> Servicos { get; set; }
        public string? Observacao { get; set; }
        public decimal Valor { get; set; }
    }
}
