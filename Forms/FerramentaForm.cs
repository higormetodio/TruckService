using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckService.Config;
using TruckService.Models;
using TruckService.Repository;

namespace TruckService.Forms
{
    public partial class FerramentaForm : System.Windows.Forms.Form
    {
        public FerramentaForm()
        {
            InitializeComponent();
        }

        private void cadastroFerramentaFuncionarioComboBox_DropDown(object sender, EventArgs e)
        {
            var repositorio = new FuncionarioRepositorio(Conexao.connection);


            cadastroFerramentaFuncionarioComboBox.DataSource = repositorio.Listar();
            cadastroFerramentaFuncionarioComboBox.DisplayMember = "Nome";
        }

        private void cadastroFerramentaSalvarButton_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario();

            if (cadastroFerramentaFuncionarioComboBox.SelectedValue is not null)
            {
                funcionario = cadastroFerramentaFuncionarioComboBox.SelectedValue as Funcionario;
            }

            var ferramenta = new Ferramenta()
            {
                Descricao = cadastroFerramentaDescricaoTextBox.Text,
                Referencia = cadastroFerramentaReferenciaTextBox.Text,
                FuncionarioId = funcionario.Id

            };

            var repositorio = new FerramentaRepositorio(Conexao.connection);
            repositorio.Inserir(ferramenta);

            Controle.desabilitarControles<TextBox>(Controls);
            Controle.desabilitarControles<ComboBox>(Controls);
            Controle.habilitarControles<Button>(Controls);
            cadastroFerramentaSalvarButton.Enabled = false;
        }
    }
}
