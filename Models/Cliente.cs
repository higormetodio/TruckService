namespace TruckService.Models
{
    public class Cliente : PessoaModel
    {
        public int Id { get; set; }
        public PedidoModel PedidoOuOrcamento { get; set; }
        public ServicoModel ServicoOuOrcamento { get; set; }

    }
}