using System.ComponentModel.DataAnnotations.Schema;

namespace TruckService.Models
{
    public abstract class PessoaModel
    {
        public string? Nome { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}