namespace TruckService.Forms
{
    partial class ListarFuncionariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarFuncionariosForm));
            cadastroFuncionarioLabel = new Label();
            listarFuncionariosNomeTextBox = new TextBox();
            listarFuncionariosNomeLabel = new Label();
            listarFuncionariosDataGridView = new DataGridView();
            listarFuncionarioDataGridViewButtonColumn = new DataGridViewButtonColumn();
            listarFuncionariosBuscarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)listarFuncionariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cadastroFuncionarioLabel
            // 
            cadastroFuncionarioLabel.AutoSize = true;
            cadastroFuncionarioLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroFuncionarioLabel.Location = new Point(307, 9);
            cadastroFuncionarioLabel.Name = "cadastroFuncionarioLabel";
            cadastroFuncionarioLabel.Size = new Size(325, 41);
            cadastroFuncionarioLabel.TabIndex = 2;
            cadastroFuncionarioLabel.Text = "Listar de Funcionários";
            // 
            // listarFuncionariosNomeTextBox
            // 
            listarFuncionariosNomeTextBox.BorderStyle = BorderStyle.FixedSingle;
            listarFuncionariosNomeTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            listarFuncionariosNomeTextBox.Location = new Point(133, 76);
            listarFuncionariosNomeTextBox.Name = "listarFuncionariosNomeTextBox";
            listarFuncionariosNomeTextBox.Size = new Size(626, 27);
            listarFuncionariosNomeTextBox.TabIndex = 3;
            listarFuncionariosNomeTextBox.KeyDown += listarFuncionariosNomeTextBox_KeyDown;
            // 
            // listarFuncionariosNomeLabel
            // 
            listarFuncionariosNomeLabel.AutoSize = true;
            listarFuncionariosNomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listarFuncionariosNomeLabel.Location = new Point(61, 76);
            listarFuncionariosNomeLabel.Name = "listarFuncionariosNomeLabel";
            listarFuncionariosNomeLabel.Size = new Size(66, 28);
            listarFuncionariosNomeLabel.TabIndex = 4;
            listarFuncionariosNomeLabel.Text = "Nome";
            // 
            // listarFuncionariosDataGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listarFuncionariosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listarFuncionariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listarFuncionariosDataGridView.Columns.AddRange(new DataGridViewColumn[] { listarFuncionarioDataGridViewButtonColumn });
            listarFuncionariosDataGridView.Location = new Point(60, 116);
            listarFuncionariosDataGridView.Name = "listarFuncionariosDataGridView";
            listarFuncionariosDataGridView.RowHeadersWidth = 51;
            listarFuncionariosDataGridView.Size = new Size(817, 483);
            listarFuncionariosDataGridView.TabIndex = 5;
            listarFuncionariosDataGridView.CellContentClick += listarFuncionariosDataGridView_CellContentClick;
            // 
            // listarFuncionarioDataGridViewButtonColumn
            // 
            listarFuncionarioDataGridViewButtonColumn.HeaderText = " ";
            listarFuncionarioDataGridViewButtonColumn.MinimumWidth = 6;
            listarFuncionarioDataGridViewButtonColumn.Name = "listarFuncionarioDataGridViewButtonColumn";
            listarFuncionarioDataGridViewButtonColumn.Text = "Detalhe";
            listarFuncionarioDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            listarFuncionarioDataGridViewButtonColumn.Width = 125;
            // 
            // listarFuncionariosBuscarButton
            // 
            listarFuncionariosBuscarButton.Location = new Point(773, 69);
            listarFuncionariosBuscarButton.Name = "listarFuncionariosBuscarButton";
            listarFuncionariosBuscarButton.Size = new Size(104, 39);
            listarFuncionariosBuscarButton.TabIndex = 36;
            listarFuncionariosBuscarButton.Text = "Buscar";
            listarFuncionariosBuscarButton.UseVisualStyleBackColor = true;
            listarFuncionariosBuscarButton.Click += listarFuncionariosBuscarButton_Click;
            // 
            // ListarFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 628);
            Controls.Add(listarFuncionariosBuscarButton);
            Controls.Add(listarFuncionariosDataGridView);
            Controls.Add(listarFuncionariosNomeLabel);
            Controls.Add(listarFuncionariosNomeTextBox);
            Controls.Add(cadastroFuncionarioLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarFuncionariosForm";
            Text = "Listar Funcionarios";
            ((System.ComponentModel.ISupportInitialize)listarFuncionariosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label cadastroFuncionarioLabel;
        private TextBox listarFuncionariosNomeTextBox;
        private Label listarFuncionariosNomeLabel;
        private DataGridView listarFuncionariosDataGridView;
        private Button listarFuncionariosBuscarButton;
        private DataGridViewButtonColumn listarFuncionarioDataGridViewButtonColumn;
    }
}