namespace TruckService.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string? EnderecoEstoque { get; set; }
        public int Quantidade { get; set; }
        public Produto? Produto { get; set; }
    }
}