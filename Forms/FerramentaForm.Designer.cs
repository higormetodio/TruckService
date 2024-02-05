namespace TruckService.Forms
{
    partial class FerramentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FerramentaForm));
            cadastroFerramentaDeletarButton = new Button();
            cadastroFerramentaAlterarButton = new Button();
            cadastroFerramentaSalvarButton = new Button();
            cadastroFerramentaDescricaoTextBox = new TextBox();
            cadastroFerramentaDescricaoLabel = new Label();
            cadastroFerramentaLabel = new Label();
            cadastroFerramentaReferenciaTextBox = new TextBox();
            cadastroFerramentaReferenciaLabel = new Label();
            cadastroFerramentaFuncionarioComboBox = new ComboBox();
            cadastroFerramentaFuncionarioLabel = new Label();
            SuspendLayout();
            // 
            // cadastroFerramentaDeletarButton
            // 
            cadastroFerramentaDeletarButton.Enabled = false;
            cadastroFerramentaDeletarButton.Location = new Point(676, 401);
            cadastroFerramentaDeletarButton.Name = "cadastroFerramentaDeletarButton";
            cadastroFerramentaDeletarButton.Size = new Size(104, 39);
            cadastroFerramentaDeletarButton.TabIndex = 6;
            cadastroFerramentaDeletarButton.Text = "Deletar";
            cadastroFerramentaDeletarButton.UseVisualStyleBackColor = true;
            cadastroFerramentaDeletarButton.Visible = false;
            // 
            // cadastroFerramentaAlterarButton
            // 
            cadastroFerramentaAlterarButton.Enabled = false;
            cadastroFerramentaAlterarButton.Location = new Point(396, 401);
            cadastroFerramentaAlterarButton.Name = "cadastroFerramentaAlterarButton";
            cadastroFerramentaAlterarButton.Size = new Size(104, 39);
            cadastroFerramentaAlterarButton.TabIndex = 5;
            cadastroFerramentaAlterarButton.Text = "Alterar";
            cadastroFerramentaAlterarButton.UseVisualStyleBackColor = true;
            cadastroFerramentaAlterarButton.Visible = false;
            // 
            // cadastroFerramentaSalvarButton
            // 
            cadastroFerramentaSalvarButton.Location = new Point(258, 401);
            cadastroFerramentaSalvarButton.Name = "cadastroFerramentaSalvarButton";
            cadastroFerramentaSalvarButton.Size = new Size(104, 39);
            cadastroFerramentaSalvarButton.TabIndex = 4;
            cadastroFerramentaSalvarButton.Text = "Salvar";
            cadastroFerramentaSalvarButton.UseVisualStyleBackColor = true;
            cadastroFerramentaSalvarButton.Click += cadastroFerramentaSalvarButton_Click;
            // 
            // cadastroFerramentaDescricaoTextBox
            // 
            cadastroFerramentaDescricaoTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFerramentaDescricaoTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFerramentaDescricaoTextBox.Location = new Point(165, 90);
            cadastroFerramentaDescricaoTextBox.Name = "cadastroFerramentaDescricaoTextBox";
            cadastroFerramentaDescricaoTextBox.Size = new Size(565, 27);
            cadastroFerramentaDescricaoTextBox.TabIndex = 1;
            // 
            // cadastroFerramentaDescricaoLabel
            // 
            cadastroFerramentaDescricaoLabel.AutoSize = true;
            cadastroFerramentaDescricaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFerramentaDescricaoLabel.Location = new Point(63, 90);
            cadastroFerramentaDescricaoLabel.Name = "cadastroFerramentaDescricaoLabel";
            cadastroFerramentaDescricaoLabel.Size = new Size(96, 28);
            cadastroFerramentaDescricaoLabel.TabIndex = 34;
            cadastroFerramentaDescricaoLabel.Text = "Descrição";
            // 
            // cadastroFerramentaLabel
            // 
            cadastroFerramentaLabel.AutoSize = true;
            cadastroFerramentaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroFerramentaLabel.Location = new Point(202, 9);
            cadastroFerramentaLabel.Name = "cadastroFerramentaLabel";
            cadastroFerramentaLabel.Size = new Size(355, 41);
            cadastroFerramentaLabel.TabIndex = 33;
            cadastroFerramentaLabel.Text = "Cadastro de Ferramenta";
            // 
            // cadastroFerramentaReferenciaTextBox
            // 
            cadastroFerramentaReferenciaTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFerramentaReferenciaTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFerramentaReferenciaTextBox.Location = new Point(165, 137);
            cadastroFerramentaReferenciaTextBox.Name = "cadastroFerramentaReferenciaTextBox";
            cadastroFerramentaReferenciaTextBox.Size = new Size(565, 27);
            cadastroFerramentaReferenciaTextBox.TabIndex = 2;
            // 
            // cadastroFerramentaReferenciaLabel
            // 
            cadastroFerramentaReferenciaLabel.AutoSize = true;
            cadastroFerramentaReferenciaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFerramentaReferenciaLabel.Location = new Point(58, 136);
            cadastroFerramentaReferenciaLabel.Name = "cadastroFerramentaReferenciaLabel";
            cadastroFerramentaReferenciaLabel.Size = new Size(101, 28);
            cadastroFerramentaReferenciaLabel.TabIndex = 39;
            cadastroFerramentaReferenciaLabel.Text = "Referência";
            // 
            // cadastroFerramentaFuncionarioComboBox
            // 
            cadastroFerramentaFuncionarioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cadastroFerramentaFuncionarioComboBox.FormattingEnabled = true;
            cadastroFerramentaFuncionarioComboBox.Location = new Point(165, 185);
            cadastroFerramentaFuncionarioComboBox.Name = "cadastroFerramentaFuncionarioComboBox";
            cadastroFerramentaFuncionarioComboBox.Size = new Size(368, 28);
            cadastroFerramentaFuncionarioComboBox.TabIndex = 3;
            cadastroFerramentaFuncionarioComboBox.DropDown += cadastroFerramentaFuncionarioComboBox_DropDown;
            // 
            // cadastroFerramentaFuncionarioLabel
            // 
            cadastroFerramentaFuncionarioLabel.AutoSize = true;
            cadastroFerramentaFuncionarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFerramentaFuncionarioLabel.Location = new Point(44, 185);
            cadastroFerramentaFuncionarioLabel.Name = "cadastroFerramentaFuncionarioLabel";
            cadastroFerramentaFuncionarioLabel.Size = new Size(115, 28);
            cadastroFerramentaFuncionarioLabel.TabIndex = 41;
            cadastroFerramentaFuncionarioLabel.Text = "Funcionário";
            // 
            // FerramentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastroFerramentaFuncionarioLabel);
            Controls.Add(cadastroFerramentaFuncionarioComboBox);
            Controls.Add(cadastroFerramentaReferenciaTextBox);
            Controls.Add(cadastroFerramentaReferenciaLabel);
            Controls.Add(cadastroFerramentaDeletarButton);
            Controls.Add(cadastroFerramentaAlterarButton);
            Controls.Add(cadastroFerramentaSalvarButton);
            Controls.Add(cadastroFerramentaDescricaoTextBox);
            Controls.Add(cadastroFerramentaDescricaoLabel);
            Controls.Add(cadastroFerramentaLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FerramentaForm";
            Text = "Ferramenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastroFerramentaDeletarButton;
        private Button cadastroFerramentaAlterarButton;
        private Button cadastroFerramentaSalvarButton;
        private TextBox cadastroFerramentaDescricaoTextBox;
        private Label cadastroFerramentaDescricaoLabel;
        private Label cadastroFerramentaLabel;
        private TextBox cadastroFerramentaReferenciaTextBox;
        private Label cadastroFerramentaReferenciaLabel;
        private ComboBox cadastroFerramentaFuncionarioComboBox;
        private Label cadastroFerramentaFuncionarioLabel;
    }
}