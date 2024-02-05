using TruckService.Models;
using TruckService.Config;
using TruckService.Repository;
using TruckService.Forms;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace TruckService
{
    public partial class FuncionarioForm : System.Windows.Forms.Form
    {
        public Funcionario Funcionario { get; set; }
        public bool Sucesso { get; set; } = false;

        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void cadastroFuncionarioSalvarButton_Click(object sender, EventArgs e)
        {
            var repositorio = new FuncionarioRepositorio(Conexao.connection);

            Funcionario = new()
            {
                Nome = cadastroFuncionarioNomeTextBox.Text,
                DataNascimento = cadastroFuncionarioDataNascimentoDateTimePicker.Value,
                CpfCnpj = cadastroFuncionarioCpfMaskedTextBox.Text,
                Telefone = cadastroFuncionarioTelefoneMaskedTextBox.Text,
                Email = cadastroFuncionarioEmailTextBox.Text,
                CEP = cadastroFuncionarioCepMaskedTextBox.Text,
                Logradouro = cadastroFuncionarioLogradouroTextBox.Text,
                Numero = Convert.ToInt32(cadastroFuncionarioNumeroTextBox.Text),
                Bairro = cadastroFuncionarioBairroTextBox.Text,
                Cidade = cadastroFuncionarioCidadeTextBox.Text,
                UF = cadastroFuncionarioUfTextBox.Text
            };

            repositorio.Inserir(Funcionario);

            Controle.desabilitarControles<TextBox>(Controls);
            Controle.desabilitarControles<DateTimePicker>(Controls);
            Controle.desabilitarControles<MaskedTextBox>(Controls);
            Controle.habilitarControles<Label>(Controls);
            Controle.habilitarControles<Button>(Controls);
            cadastroFuncionarioSalvarButton.Enabled = false;
        }

        private void cadastroFuncionarioFerramentasButton_Click(object sender, EventArgs e)
        {
            FerramentasFuncionarioForm ferramentas = new();
            ferramentas.Funcionario = Funcionario;
            ferramentas.Show();
        }

        private void cadastroFuncionarioAlterarButton_Click(object sender, EventArgs e)
        {
            Controle.habilitarControles<TextBox>(Controls);
            Controle.habilitarControles<DateTimePicker>(Controls);
            Controle.habilitarControles<MaskedTextBox>(Controls);
            Controle.desabilitarControles<Label>(Controls);
            Controle.desabilitarControles<Button>(Controls);
            cadastroFuncionarioSalvarButton.Visible = false;
            cadastroFuncionarioSalvarAlteracaoButton.Visible = true;
            cadastroFuncionarioSalvarAlteracaoButton.Enabled = true;
        }

        private void cadastroFuncionarioSalvarAlteracaoButton_Click(object sender, EventArgs e)
        {
            var repositorio = new FuncionarioRepositorio(Conexao.connection);

            Funcionario.Nome = cadastroFuncionarioNomeTextBox.Text;
            Funcionario.DataNascimento = cadastroFuncionarioDataNascimentoDateTimePicker.Value;
            Funcionario.CpfCnpj = cadastroFuncionarioCpfMaskedTextBox.Text;
            Funcionario.Telefone = cadastroFuncionarioTelefoneMaskedTextBox.Text;
            Funcionario.Email = cadastroFuncionarioEmailTextBox.Text;
            Funcionario.CEP = cadastroFuncionarioCepMaskedTextBox.Text;
            Funcionario.Logradouro = cadastroFuncionarioLogradouroTextBox.Text;
            Funcionario.Numero = Convert.ToInt32(cadastroFuncionarioNumeroTextBox.Text);
            Funcionario.Bairro = cadastroFuncionarioBairroTextBox.Text;
            Funcionario.Cidade = cadastroFuncionarioCidadeTextBox.Text;
            Funcionario.UF = cadastroFuncionarioUfTextBox.Text;

            repositorio.Atualizar(Funcionario);

            Controle.desabilitarControles<TextBox>(Controls);
            Controle.desabilitarControles<DateTimePicker>(Controls);
            Controle.desabilitarControles<MaskedTextBox>(Controls);
            Controle.habilitarControles<Label>(Controls);
            Controle.habilitarControles<Button>(Controls);
            cadastroFuncionarioSalvarAlteracaoButton.Enabled = false;

            MessageBox.Show($"O Funcionário {Funcionario.Nome} foi atualizado");

            Sucesso = true;
        }

        private void cadastroFuncionarioDeletarButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Deletar Funcionário", MessageBoxButtons.YesNo);
            
            if (resultado == DialogResult.Yes)
            {
                var repositorio = new FuncionarioRepositorio(Conexao.connection);

                repositorio.Deletar(Funcionario);

                MessageBox.Show($"O Funcionário {Funcionario.Nome} foi excluído");
            }

            Sucesso = true;

            Hide();
        }

        private void FuncionarioForm_Load(object sender, EventArgs e)
        {
            if (Funcionario is not null)
            {
                cadastroFuncionarioNomeTextBox.Text = Funcionario.Nome;
                cadastroFuncionarioDataNascimentoDateTimePicker.Value = Funcionario.DataNascimento;
                cadastroFuncionarioCpfMaskedTextBox.Text = Funcionario.CpfCnpj;
                cadastroFuncionarioTelefoneMaskedTextBox.Text = Funcionario.Telefone;
                cadastroFuncionarioEmailTextBox.Text = Funcionario.Email;
                cadastroFuncionarioCepMaskedTextBox.Text = Funcionario.CEP;
                cadastroFuncionarioLogradouroTextBox.Text = Funcionario.Logradouro;
                cadastroFuncionarioNumeroTextBox.Text = Funcionario.Numero.ToString();
                cadastroFuncionarioBairroTextBox.Text = Funcionario.Bairro;
                cadastroFuncionarioCidadeTextBox.Text = Funcionario.Cidade;
                cadastroFuncionarioUfTextBox.Text = Funcionario.UF;
            }
        }
    }
}
