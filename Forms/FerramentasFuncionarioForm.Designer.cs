namespace TruckService.Forms
{
    partial class FerramentasFuncionarioForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FerramentasFuncionarioForm));
            selecaoFerramentasFuncionarioDataGridView = new DataGridView();
            selecaoFerramentasFuncionarioDataGridCheckBox = new DataGridViewCheckBoxColumn();
            selecaoFerramentaFuncionarioLabel = new Label();
            cadastroFerramentasFuncionarioSalvarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)selecaoFerramentasFuncionarioDataGridView).BeginInit();
            SuspendLayout();
            // 
            // selecaoFerramentasFuncionarioDataGridView
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            selecaoFerramentasFuncionarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            selecaoFerramentasFuncionarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selecaoFerramentasFuncionarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { selecaoFerramentasFuncionarioDataGridCheckBox });
            selecaoFerramentasFuncionarioDataGridView.Location = new Point(78, 69);
            selecaoFerramentasFuncionarioDataGridView.Name = "selecaoFerramentasFuncionarioDataGridView";
            selecaoFerramentasFuncionarioDataGridView.RowHeadersWidth = 51;
            selecaoFerramentasFuncionarioDataGridView.Size = new Size(695, 483);
            selecaoFerramentasFuncionarioDataGridView.TabIndex = 0;
            // 
            // selecaoFerramentasFuncionarioDataGridCheckBox
            // 
            selecaoFerramentasFuncionarioDataGridCheckBox.HeaderText = "Associadas";
            selecaoFerramentasFuncionarioDataGridCheckBox.MinimumWidth = 6;
            selecaoFerramentasFuncionarioDataGridCheckBox.Name = "selecaoFerramentasFuncionarioDataGridCheckBox";
            selecaoFerramentasFuncionarioDataGridCheckBox.Width = 125;
            // 
            // selecaoFerramentaFuncionarioLabel
            // 
            selecaoFerramentaFuncionarioLabel.AutoSize = true;
            selecaoFerramentaFuncionarioLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selecaoFerramentaFuncionarioLabel.Location = new Point(215, 9);
            selecaoFerramentaFuncionarioLabel.Name = "selecaoFerramentaFuncionarioLabel";
            selecaoFerramentaFuncionarioLabel.Size = new Size(411, 41);
            selecaoFerramentaFuncionarioLabel.TabIndex = 34;
            selecaoFerramentaFuncionarioLabel.Text = "Ferramentas do Funcionário";
            // 
            // cadastroFerramentasFuncionarioSalvarButton
            // 
            cadastroFerramentasFuncionarioSalvarButton.Location = new Point(385, 577);
            cadastroFerramentasFuncionarioSalvarButton.Name = "cadastroFerramentasFuncionarioSalvarButton";
            cadastroFerramentasFuncionarioSalvarButton.Size = new Size(104, 39);
            cadastroFerramentasFuncionarioSalvarButton.TabIndex = 35;
            cadastroFerramentasFuncionarioSalvarButton.Text = "Salvar";
            cadastroFerramentasFuncionarioSalvarButton.UseVisualStyleBackColor = true;
            cadastroFerramentasFuncionarioSalvarButton.Click += cadastroFerramentasFuncionarioSalvarButton_Click;
            // 
            // FerramentasFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 628);
            Controls.Add(cadastroFerramentasFuncionarioSalvarButton);
            Controls.Add(selecaoFerramentaFuncionarioLabel);
            Controls.Add(selecaoFerramentasFuncionarioDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FerramentasFuncionarioForm";
            Text = "Ferramentas do Funcionário";
            Load += FerramentasFuncionarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)selecaoFerramentasFuncionarioDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView selecaoFerramentasFuncionarioDataGridView;
        private Label selecaoFerramentaFuncionarioLabel;
        private Button cadastroFerramentasFuncionarioSalvarButton;
        private DataGridViewCheckBoxColumn selecaoFerramentasFuncionarioDataGridCheckBox;
    }
}