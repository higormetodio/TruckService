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
    public partial class cadastroClienteForm : Form
    {
        public cadastroClienteForm()
        {
            InitializeComponent();
        }

        private void cadastroClienteCpfCnpjMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (cadastroClienteCpfCnpjMaskedTextBox.Text.Length == 11)
            {
                cadastroClienteCpfCnpjMaskedTextBox.Mask = "000,000,000-00";
            }
            else if (cadastroClienteCpfCnpjMaskedTextBox.Text.Length == 14)
            {
                cadastroClienteCpfCnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            }
            else
            {
                MessageBox.Show("CPF/CNPJ Inválido");
            }
        }
    }
}
