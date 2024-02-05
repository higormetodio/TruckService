using Dapper.Contrib.Extensions;

namespace TruckService.Models
{
    [Table("Funcionario")]
    public class Funcionario : PessoaModel
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        [Write(false)]
        public List<Ferramenta> Ferramentas { get; set; }

    }
}
