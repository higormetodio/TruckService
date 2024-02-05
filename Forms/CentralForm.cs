using TruckService.Forms;

namespace TruckService
{
    public partial class CentralForm : System.Windows.Forms.Form
    {
        public CentralForm()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioForm funcionario = new FuncionarioForm();
            funcionario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cliente = new cadastroClienteForm();
            cliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fornecedor = new FornecedorForm();
            fornecedor.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoria = new cadastroCategoriaForm();
            categoria.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoForm();
            produto.Show();
        }

        private void ferramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ferramenta = new FerramentaForm();
            ferramenta.Show();
        }

        private void ordemServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordemServico = new OrdemServicoForm();
            ordemServico.Show();
        }

        private void pedidoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidoVenda = new PedidoVendaForm();
            pedidoVenda.Show();
        }

        private void orcamentoServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orcamentoServico = new OrcamentoServicoForm();
            orcamentoServico.Show();
        }

        private void orcamentoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orcamentoVenda = new OrcamentoVendaForm();
            orcamentoVenda.Show();
        }

        private void posicaoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var posicaoEstoque = new PosicaoEstoqueForm();
            posicaoEstoque.Show();
        }

        private void listarFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var posicaoFerramenta = new PosicaoFerramentaForm();
            posicaoFerramenta.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listarFuncionarios = new ListarFuncionariosForm();
            listarFuncionarios.Show();
        }
    }
}
