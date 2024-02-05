namespace TruckService.Forms
{
    partial class PosicaoEstoqueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosicaoEstoqueForm));
            posicaoEstoqueNomesProdutosTextBox = new TextBox();
            posicaoEstoqueNomesProdutosLabel = new Label();
            posicaoEstoqueLabel = new Label();
            posicaoEstoqueCodigosProdutosTextBox = new TextBox();
            posicaoEstoqueCodigosProdutosLabel = new Label();
            posicaoEstoqueBuscarButton = new Button();
            posicaoEstoqueDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)posicaoEstoqueDataGridView).BeginInit();
            SuspendLayout();
            // 
            // posicaoEstoqueNomesProdutosTextBox
            // 
            posicaoEstoqueNomesProdutosTextBox.BorderStyle = BorderStyle.FixedSingle;
            posicaoEstoqueNomesProdutosTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            posicaoEstoqueNomesProdutosTextBox.Location = new Point(243, 92);
            posicaoEstoqueNomesProdutosTextBox.Name = "posicaoEstoqueNomesProdutosTextBox";
            posicaoEstoqueNomesProdutosTextBox.Size = new Size(627, 27);
            posicaoEstoqueNomesProdutosTextBox.TabIndex = 26;
            // 
            // posicaoEstoqueNomesProdutosLabel
            // 
            posicaoEstoqueNomesProdutosLabel.AutoSize = true;
            posicaoEstoqueNomesProdutosLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posicaoEstoqueNomesProdutosLabel.Location = new Point(41, 91);
            posicaoEstoqueNomesProdutosLabel.Name = "posicaoEstoqueNomesProdutosLabel";
            posicaoEstoqueNomesProdutosLabel.Size = new Size(196, 28);
            posicaoEstoqueNomesProdutosLabel.TabIndex = 27;
            posicaoEstoqueNomesProdutosLabel.Text = "Nomes dos Produtos";
            // 
            // posicaoEstoqueLabel
            // 
            posicaoEstoqueLabel.AutoSize = true;
            posicaoEstoqueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            posicaoEstoqueLabel.Location = new Point(392, 9);
            posicaoEstoqueLabel.Name = "posicaoEstoqueLabel";
            posicaoEstoqueLabel.Size = new Size(286, 41);
            posicaoEstoqueLabel.TabIndex = 28;
            posicaoEstoqueLabel.Text = "Posição de Estoque";
            // 
            // posicaoEstoqueCodigosProdutosTextBox
            // 
            posicaoEstoqueCodigosProdutosTextBox.BorderStyle = BorderStyle.FixedSingle;
            posicaoEstoqueCodigosProdutosTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            posicaoEstoqueCodigosProdutosTextBox.Location = new Point(243, 144);
            posicaoEstoqueCodigosProdutosTextBox.Name = "posicaoEstoqueCodigosProdutosTextBox";
            posicaoEstoqueCodigosProdutosTextBox.Size = new Size(627, 27);
            posicaoEstoqueCodigosProdutosTextBox.TabIndex = 29;
            posicaoEstoqueCodigosProdutosTextBox.TextChanged += textBox1_TextChanged;
            // 
            // posicaoEstoqueCodigosProdutosLabel
            // 
            posicaoEstoqueCodigosProdutosLabel.AutoSize = true;
            posicaoEstoqueCodigosProdutosLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posicaoEstoqueCodigosProdutosLabel.Location = new Point(30, 143);
            posicaoEstoqueCodigosProdutosLabel.Name = "posicaoEstoqueCodigosProdutosLabel";
            posicaoEstoqueCodigosProdutosLabel.Size = new Size(207, 28);
            posicaoEstoqueCodigosProdutosLabel.TabIndex = 30;
            posicaoEstoqueCodigosProdutosLabel.Text = "Códigos dos Produtos";
            // 
            // posicaoEstoqueBuscarButton
            // 
            posicaoEstoqueBuscarButton.Location = new Point(928, 104);
            posicaoEstoqueBuscarButton.Name = "posicaoEstoqueBuscarButton";
            posicaoEstoqueBuscarButton.Size = new Size(104, 39);
            posicaoEstoqueBuscarButton.TabIndex = 31;
            posicaoEstoqueBuscarButton.Text = "Buscar";
            posicaoEstoqueBuscarButton.UseVisualStyleBackColor = true;
            // 
            // posicaoEstoqueDataGridView
            // 
            posicaoEstoqueDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            posicaoEstoqueDataGridView.Location = new Point(245, 203);
            posicaoEstoqueDataGridView.Name = "posicaoEstoqueDataGridView";
            posicaoEstoqueDataGridView.RowHeadersWidth = 51;
            posicaoEstoqueDataGridView.Size = new Size(625, 358);
            posicaoEstoqueDataGridView.TabIndex = 32;
            // 
            // PosicaoEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 620);
            Controls.Add(posicaoEstoqueDataGridView);
            Controls.Add(posicaoEstoqueBuscarButton);
            Controls.Add(posicaoEstoqueCodigosProdutosTextBox);
            Controls.Add(posicaoEstoqueCodigosProdutosLabel);
            Controls.Add(posicaoEstoqueLabel);
            Controls.Add(posicaoEstoqueNomesProdutosTextBox);
            Controls.Add(posicaoEstoqueNomesProdutosLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PosicaoEstoqueForm";
            Text = "Posicao de Estoque";
            ((System.ComponentModel.ISupportInitialize)posicaoEstoqueDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox posicaoEstoqueNomesProdutosTextBox;
        private Label posicaoEstoqueNomesProdutosLabel;
        private Label posicaoEstoqueLabel;
        private TextBox posicaoEstoqueCodigosProdutosTextBox;
        private Label posicaoEstoqueCodigosProdutosLabel;
        private Button posicaoEstoqueBuscarButton;
        private DataGridView posicaoEstoqueDataGridView;
    }
}