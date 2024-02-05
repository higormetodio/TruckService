namespace TruckService.Forms
{
    partial class ProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoForm));
            cadastroProdutoDescricaoTextBox = new TextBox();
            cadastroProdutoDescricaoLabel = new Label();
            cadastroFornecedorLabel = new Label();
            cadastroProdutoCategoriaLabel = new Label();
            cadastroProdutoCategoriaComboBox = new ComboBox();
            cadastroProdutoFornecedorComboBox = new ComboBox();
            cadastroProdutoForneceodrLabel = new Label();
            cadastroProdutoPrecoLabel = new Label();
            cadastroProdutoPrecoMaskedTextBox = new MaskedTextBox();
            cadastroCadastroDeletarButton = new Button();
            cadastroProdutoAlterarButton = new Button();
            cadastroProdutoSalvarButton = new Button();
            SuspendLayout();
            // 
            // cadastroProdutoDescricaoTextBox
            // 
            cadastroProdutoDescricaoTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroProdutoDescricaoTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroProdutoDescricaoTextBox.Location = new Point(148, 115);
            cadastroProdutoDescricaoTextBox.Name = "cadastroProdutoDescricaoTextBox";
            cadastroProdutoDescricaoTextBox.Size = new Size(592, 27);
            cadastroProdutoDescricaoTextBox.TabIndex = 1;
            // 
            // cadastroProdutoDescricaoLabel
            // 
            cadastroProdutoDescricaoLabel.AutoSize = true;
            cadastroProdutoDescricaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroProdutoDescricaoLabel.Location = new Point(46, 114);
            cadastroProdutoDescricaoLabel.Name = "cadastroProdutoDescricaoLabel";
            cadastroProdutoDescricaoLabel.Size = new Size(96, 28);
            cadastroProdutoDescricaoLabel.TabIndex = 55;
            cadastroProdutoDescricaoLabel.Text = "Descrição";
            // 
            // cadastroFornecedorLabel
            // 
            cadastroFornecedorLabel.AutoSize = true;
            cadastroFornecedorLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroFornecedorLabel.Location = new Point(400, 10);
            cadastroFornecedorLabel.Name = "cadastroFornecedorLabel";
            cadastroFornecedorLabel.Size = new Size(309, 41);
            cadastroFornecedorLabel.TabIndex = 54;
            cadastroFornecedorLabel.Text = "Cadastro de Produto";
            // 
            // cadastroProdutoCategoriaLabel
            // 
            cadastroProdutoCategoriaLabel.AutoSize = true;
            cadastroProdutoCategoriaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroProdutoCategoriaLabel.Location = new Point(45, 160);
            cadastroProdutoCategoriaLabel.Name = "cadastroProdutoCategoriaLabel";
            cadastroProdutoCategoriaLabel.Size = new Size(97, 28);
            cadastroProdutoCategoriaLabel.TabIndex = 57;
            cadastroProdutoCategoriaLabel.Text = "Categoria";
            // 
            // cadastroProdutoCategoriaComboBox
            // 
            cadastroProdutoCategoriaComboBox.FormattingEnabled = true;
            cadastroProdutoCategoriaComboBox.Location = new Point(148, 160);
            cadastroProdutoCategoriaComboBox.Name = "cadastroProdutoCategoriaComboBox";
            cadastroProdutoCategoriaComboBox.Size = new Size(353, 28);
            cadastroProdutoCategoriaComboBox.TabIndex = 2;
            // 
            // cadastroProdutoFornecedorComboBox
            // 
            cadastroProdutoFornecedorComboBox.FormattingEnabled = true;
            cadastroProdutoFornecedorComboBox.Location = new Point(148, 207);
            cadastroProdutoFornecedorComboBox.Name = "cadastroProdutoFornecedorComboBox";
            cadastroProdutoFornecedorComboBox.Size = new Size(472, 28);
            cadastroProdutoFornecedorComboBox.TabIndex = 3;
            // 
            // cadastroProdutoForneceodrLabel
            // 
            cadastroProdutoForneceodrLabel.AutoSize = true;
            cadastroProdutoForneceodrLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroProdutoForneceodrLabel.Location = new Point(30, 207);
            cadastroProdutoForneceodrLabel.Name = "cadastroProdutoForneceodrLabel";
            cadastroProdutoForneceodrLabel.Size = new Size(112, 28);
            cadastroProdutoForneceodrLabel.TabIndex = 59;
            cadastroProdutoForneceodrLabel.Text = "Fornecedor";
            // 
            // cadastroProdutoPrecoLabel
            // 
            cadastroProdutoPrecoLabel.AutoSize = true;
            cadastroProdutoPrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroProdutoPrecoLabel.Location = new Point(81, 255);
            cadastroProdutoPrecoLabel.Name = "cadastroProdutoPrecoLabel";
            cadastroProdutoPrecoLabel.Size = new Size(61, 28);
            cadastroProdutoPrecoLabel.TabIndex = 62;
            cadastroProdutoPrecoLabel.Text = "Preço";
            // 
            // cadastroProdutoPrecoMaskedTextBox
            // 
            cadastroProdutoPrecoMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroProdutoPrecoMaskedTextBox.Location = new Point(148, 255);
            cadastroProdutoPrecoMaskedTextBox.Mask = "$";
            cadastroProdutoPrecoMaskedTextBox.Name = "cadastroProdutoPrecoMaskedTextBox";
            cadastroProdutoPrecoMaskedTextBox.Size = new Size(203, 27);
            cadastroProdutoPrecoMaskedTextBox.TabIndex = 4;
            // 
            // cadastroCadastroDeletarButton
            // 
            cadastroCadastroDeletarButton.Enabled = false;
            cadastroCadastroDeletarButton.Location = new Point(936, 385);
            cadastroCadastroDeletarButton.Name = "cadastroCadastroDeletarButton";
            cadastroCadastroDeletarButton.Size = new Size(104, 39);
            cadastroCadastroDeletarButton.TabIndex = 7;
            cadastroCadastroDeletarButton.Text = "Deletar";
            cadastroCadastroDeletarButton.UseVisualStyleBackColor = true;
            // 
            // cadastroProdutoAlterarButton
            // 
            cadastroProdutoAlterarButton.Enabled = false;
            cadastroProdutoAlterarButton.Location = new Point(561, 385);
            cadastroProdutoAlterarButton.Name = "cadastroProdutoAlterarButton";
            cadastroProdutoAlterarButton.Size = new Size(104, 39);
            cadastroProdutoAlterarButton.TabIndex = 6;
            cadastroProdutoAlterarButton.Text = "Alterar";
            cadastroProdutoAlterarButton.UseVisualStyleBackColor = true;
            // 
            // cadastroProdutoSalvarButton
            // 
            cadastroProdutoSalvarButton.Location = new Point(423, 385);
            cadastroProdutoSalvarButton.Name = "cadastroProdutoSalvarButton";
            cadastroProdutoSalvarButton.Size = new Size(104, 39);
            cadastroProdutoSalvarButton.TabIndex = 5;
            cadastroProdutoSalvarButton.Text = "Salvar";
            cadastroProdutoSalvarButton.UseVisualStyleBackColor = true;
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 443);
            Controls.Add(cadastroCadastroDeletarButton);
            Controls.Add(cadastroProdutoAlterarButton);
            Controls.Add(cadastroProdutoSalvarButton);
            Controls.Add(cadastroProdutoPrecoMaskedTextBox);
            Controls.Add(cadastroProdutoPrecoLabel);
            Controls.Add(cadastroProdutoFornecedorComboBox);
            Controls.Add(cadastroProdutoForneceodrLabel);
            Controls.Add(cadastroProdutoCategoriaComboBox);
            Controls.Add(cadastroProdutoCategoriaLabel);
            Controls.Add(cadastroProdutoDescricaoTextBox);
            Controls.Add(cadastroProdutoDescricaoLabel);
            Controls.Add(cadastroFornecedorLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProdutoForm";
            Text = "Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cadastroProdutoDescricaoTextBox;
        private Label cadastroProdutoDescricaoLabel;
        private Label cadastroFornecedorLabel;
        private Label cadastroProdutoCategoriaLabel;
        private ComboBox cadastroProdutoCategoriaComboBox;
        private ComboBox cadastroProdutoFornecedorComboBox;
        private Label cadastroProdutoForneceodrLabel;
        private Label cadastroProdutoPrecoLabel;
        private MaskedTextBox cadastroProdutoPrecoMaskedTextBox;
        private Button cadastroCadastroDeletarButton;
        private Button cadastroProdutoAlterarButton;
        private Button cadastroProdutoSalvarButton;
    }
}