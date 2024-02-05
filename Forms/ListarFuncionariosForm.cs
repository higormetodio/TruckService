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
    public partial class ListarFuncionariosForm : Form
    {
        public ListarFuncionariosForm()
        {
            InitializeComponent();
        }

        private void listarFuncionariosBuscarButton_Click(object sender, EventArgs e)
        {
            var repositorio = new FuncionarioRepositorio(Conexao.connection);

            if (listarFuncionariosNomeTextBox.Text == "")
            {
                List<Funcionario> funcionarios = repositorio.Listar().ToList();
                listarFuncionariosDataGridView.DataSource = funcionarios;


            }
            else
            {
                var funcionario = repositorio.ListarNome(listarFuncionariosNomeTextBox.Text);
                listarFuncionariosDataGridView.DataSource = funcionario;
            }

            listarFuncionarioDataGridViewButtonColumn.Visible = true;
            listarFuncionariosDataGridView.Columns["Id"].Visible = true;
            listarFuncionariosDataGridView.Columns["Nome"].Visible = true;
            listarFuncionariosDataGridView.Columns["Telefone"].Visible = true;
            listarFuncionariosDataGridView.Columns["DataNascimento"].Visible = true;
            listarFuncionariosDataGridView.Columns["DataNascimento"].HeaderText = "Data Nacimento";
            listarFuncionariosDataGridView.Columns["Id"].DisplayIndex = 1;
            listarFuncionariosDataGridView.Columns["Nome"].DisplayIndex = 2;
            listarFuncionariosDataGridView.Columns["Telefone"].DisplayIndex = 3;
            listarFuncionariosDataGridView.Columns["DataNascimento"].DisplayIndex = 4;
        }

        private void listarFuncionariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var repositorio = new FuncionarioRepositorio(Conexao.connection);

            FuncionarioForm funcionarioForm = new();

            Controle.desabilitarControles<Label>(funcionarioForm.Controls);
            Controle.desabilitarControles<TextBox>(funcionarioForm.Controls);
            Controle.desabilitarControles<DateTimePicker>(funcionarioForm.Controls);
            Controle.desabilitarControles<MaskedTextBox>(funcionarioForm.Controls);
            Controle.habilitarControles<Button>(funcionarioForm.Controls);
            funcionarioForm.Controls["cadastroFuncionarioSalvarButton"].Enabled = false;

            var row = listarFuncionariosDataGridView.Rows[e.RowIndex];
            var cell = row.Cells[1];
            int id = Convert.ToInt32(cell.Value);

            funcionarioForm.Funcionario = repositorio.Listar(id);

            funcionarioForm.ShowDialog();

            if (funcionarioForm.Sucesso)
                listarFuncionariosBuscarButton_Click(sender, e);
        }

        private void listarFuncionariosNomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listarFuncionariosBuscarButton.PerformClick();
            }
        }
    }
}
