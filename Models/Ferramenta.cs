using System.ComponentModel.DataAnnotations.Schema;

namespace TruckService.Models
{
    [Table("[Ferramenta]")]
    public class Ferramenta
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string Referencia { get; set; }
        public int FuncionarioId { get; set; }
    }
}