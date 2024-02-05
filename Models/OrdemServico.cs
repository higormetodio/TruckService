namespace TruckService.Models
{
    public class OrdemServico : ServicoModel
    {
        public int Id { get; set; }
        public Funcionario? Funcionario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public List<PedidoVenda> Pedidos { get; set; }
        public bool Pagamento { get; set; }
    }
}