namespace TruckService
{
    partial class cadastroCategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCategoriaForm));
            cadastroCategoriaDescricaoTextBox = new TextBox();
            cadastroCategoriaDescricaoLabel = new Label();
            cadastroCategoriaLabel = new Label();
            cadastroFornecedorDeletarButton = new Button();
            cadastroFornecedorAlterarButton = new Button();
            cadastroFornecedorSalvarButton = new Button();
            SuspendLayout();
            // 
            // cadastroCategoriaDescricaoTextBox
            // 
            cadastroCategoriaDescricaoTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroCategoriaDescricaoTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroCategoriaDescricaoTextBox.Location = new Point(133, 88);
            cadastroCategoriaDescricaoTextBox.Name = "cadastroCategoriaDescricaoTextBox";
            cadastroCategoriaDescricaoTextBox.Size = new Size(565, 27);
            cadastroCategoriaDescricaoTextBox.TabIndex = 26;
            // 
            // cadastroCategoriaDescricaoLabel
            // 
            cadastroCategoriaDescricaoLabel.AutoSize = true;
            cadastroCategoriaDescricaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroCategoriaDescricaoLabel.Location = new Point(31, 88);
            cadastroCategoriaDescricaoLabel.Name = "cadastroCategoriaDescricaoLabel";
            cadastroCategoriaDescricaoLabel.Size = new Size(96, 28);
            cadastroCategoriaDescricaoLabel.TabIndex = 28;
            cadastroCategoriaDescricaoLabel.Text = "Descrição";
            // 
            // cadastroCategoriaLabel
            // 
            cadastroCategoriaLabel.AutoSize = true;
            cadastroCategoriaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroCategoriaLabel.Location = new Point(227, 9);
            cadastroCategoriaLabel.Name = "cadastroCategoriaLabel";
            cadastroCategoriaLabel.Size = new Size(331, 41);
            cadastroCategoriaLabel.TabIndex = 27;
            cadastroCategoriaLabel.Text = "Cadastro de Categoria";
            // 
            // cadastroFornecedorDeletarButton
            // 
            cadastroFornecedorDeletarButton.Enabled = false;
            cadastroFornecedorDeletarButton.Location = new Point(687, 399);
            cadastroFornecedorDeletarButton.Name = "cadastroFornecedorDeletarButton";
            cadastroFornecedorDeletarButton.Size = new Size(104, 39);
            cadastroFornecedorDeletarButton.TabIndex = 31;
            cadastroFornecedorDeletarButton.Text = "Deletar";
            cadastroFornecedorDeletarButton.UseVisualStyleBackColor = true;
            // 
            // cadastroFornecedorAlterarButton
            // 
            cadastroFornecedorAlterarButton.Enabled = false;
            cadastroFornecedorAlterarButton.Location = new Point(407, 399);
            cadastroFornecedorAlterarButton.Name = "cadastroFornecedorAlterarButton";
            cadastroFornecedorAlterarButton.Size = new Size(104, 39);
            cadastroFornecedorAlterarButton.TabIndex = 30;
            cadastroFornecedorAlterarButton.Text = "Alterar";
            cadastroFornecedorAlterarButton.UseVisualStyleBackColor = true;
            // 
            // cadastroFornecedorSalvarButton
            // 
            cadastroFornecedorSalvarButton.Location = new Point(269, 399);
            cadastroFornecedorSalvarButton.Name = "cadastroFornecedorSalvarButton";
            cadastroFornecedorSalvarButton.Size = new Size(104, 39);
            cadastroFornecedorSalvarButton.TabIndex = 29;
            cadastroFornecedorSalvarButton.Text = "Salvar";
            cadastroFornecedorSalvarButton.UseVisualStyleBackColor = true;
            // 
            // cadastroCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastroFornecedorDeletarButton);
            Controls.Add(cadastroFornecedorAlterarButton);
            Controls.Add(cadastroFornecedorSalvarButton);
            Controls.Add(cadastroCategoriaDescricaoTextBox);
            Controls.Add(cadastroCategoriaDescricaoLabel);
            Controls.Add(cadastroCategoriaLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "cadastroCategoriaForm";
            Text = "Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cadastroCategoriaDescricaoTextBox;
        private Label cadastroCategoriaDescricaoLabel;
        private Label cadastroCategoriaLabel;
        private Button cadastroFornecedorDeletarButton;
        private Button cadastroFornecedorAlterarButton;
        private Button cadastroFornecedorSalvarButton;
    }
}