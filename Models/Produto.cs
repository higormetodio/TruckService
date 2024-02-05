namespace TruckService.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}