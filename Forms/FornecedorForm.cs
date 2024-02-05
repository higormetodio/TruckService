using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckService
{
    public partial class FornecedorForm : Form
    {
        public FornecedorForm()
        {
            InitializeComponent();
        }

        private void cadastroFornecedorCpfCnpjMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (cadastroFornecedorCpfCnpjMaskedTextBox.Text.Length == 11)
            {
                cadastroFornecedorCpfCnpjMaskedTextBox.Mask = "000,000,000-00";
            }
            else if (cadastroFornecedorCpfCnpjMaskedTextBox.Text.Length == 14)
            {
                cadastroFornecedorCpfCnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            }
            else
            {
                MessageBox.Show("CPF/CNPJ Inválido");
            }
        }
    }
}
