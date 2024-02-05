using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckService.Models
{
    public class OrcamentoServico : ServicoModel
    {
        public int Id { get; set; }
        public DateTime DataPrazo { get; set; }
    }
}
