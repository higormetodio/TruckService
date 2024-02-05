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
    public partial class FerramentasFuncionarioForm : System.Windows.Forms.Form
    {
        public Funcionario Funcionario { get; set; } = new();
        public FerramentasFuncionarioForm()
        {
            InitializeComponent();
        }

        private void FerramentasFuncionarioForm_Load(object sender, EventArgs e)
        {
            var repositorio = new FerramentaRepositorio(Conexao.connection);

            var ferramentas = repositorio.ListarFerramentas(Funcionario.Id);

            selecaoFerramentasFuncionarioDataGridView.DataSource = ferramentas;
            selecaoFerramentasFuncionarioDataGridView.Columns["Descricao"].HeaderText = "Descrição";
            selecaoFerramentasFuncionarioDataGridView.Columns["Referencia"].HeaderText = "Referência";
            selecaoFerramentasFuncionarioDataGridView.Columns["FuncionarioId"].Visible = false;

        }

        private void cadastroFerramentasFuncionarioSalvarButton_Click(object sender, EventArgs e)
        {
            var repositorio = new FerramentaRepositorio(Conexao.connection);

            // Buscar todas as linhas do DatagridView e associar a uma ferramenta.
            foreach (DataGridViewRow item in selecaoFerramentasFuncionarioDataGridView.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == true)
                {
                    repositorio.Atualizar(new Ferramenta()
                    {
                        Id = Convert.ToInt32(item.Cells["Id"].Value.ToString()),
                        Descricao = item.Cells["Descricao"].Value.ToString(),
                        Referencia = item.Cells["Referencia"].Value.ToString(),
                        FuncionarioId = Funcionario.Id
                    });
                }
            }

            //Sair do formulário
            Hide();
        }
    }
}
