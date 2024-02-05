namespace TruckService.Forms
{
    partial class PosicaoFerramentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosicaoFerramentaForm));
            posicaoFerramentaDataGridView = new DataGridView();
            posicaoEstoqueBuscarButton = new Button();
            posicaoFerramentaCodigosFerramentasTextBox = new TextBox();
            posicaoFerramentaCodigosFerramentasLabel = new Label();
            posicaoFerramentaLabel = new Label();
            posicaoFerramentaNomesFerramentasTextBox = new TextBox();
            posicaoFerramentaNomesFerramentasLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)posicaoFerramentaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // posicaoFerramentaDataGridView
            // 
            posicaoFerramentaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            posicaoFerramentaDataGridView.Location = new Point(260, 202);
            posicaoFerramentaDataGridView.Name = "posicaoFerramentaDataGridView";
            posicaoFerramentaDataGridView.RowHeadersWidth = 51;
            posicaoFerramentaDataGridView.Size = new Size(625, 358);
            posicaoFerramentaDataGridView.TabIndex = 39;
            // 
            // posicaoEstoqueBuscarButton
            // 
            posicaoEstoqueBuscarButton.Location = new Point(943, 103);
            posicaoEstoqueBuscarButton.Name = "posicaoEstoqueBuscarButton";
            posicaoEstoqueBuscarButton.Size = new Size(104, 39);
            posicaoEstoqueBuscarButton.TabIndex = 38;
            posicaoEstoqueBuscarButton.Text = "Buscar";
            posicaoEstoqueBuscarButton.UseVisualStyleBackColor = true;
            // 
            // posicaoFerramentaCodigosFerramentasTextBox
            // 
            posicaoFerramentaCodigosFerramentasTextBox.BorderStyle = BorderStyle.FixedSingle;
            posicaoFerramentaCodigosFerramentasTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            posicaoFerramentaCodigosFerramentasTextBox.Location = new Point(258, 143);
            posicaoFerramentaCodigosFerramentasTextBox.Name = "posicaoFerramentaCodigosFerramentasTextBox";
            posicaoFerramentaCodigosFerramentasTextBox.Size = new Size(627, 27);
            posicaoFerramentaCodigosFerramentasTextBox.TabIndex = 36;
            // 
            // posicaoFerramentaCodigosFerramentasLabel
            // 
            posicaoFerramentaCodigosFerramentasLabel.AutoSize = true;
            posicaoFerramentaCodigosFerramentasLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posicaoFerramentaCodigosFerramentasLabel.Location = new Point(20, 142);
            posicaoFerramentaCodigosFerramentasLabel.Name = "posicaoFerramentaCodigosFerramentasLabel";
            posicaoFerramentaCodigosFerramentasLabel.Size = new Size(232, 28);
            posicaoFerramentaCodigosFerramentasLabel.TabIndex = 37;
            posicaoFerramentaCodigosFerramentasLabel.Text = "Códigos das Ferramentas";
            // 
            // posicaoFerramentaLabel
            // 
            posicaoFerramentaLabel.AutoSize = true;
            posicaoFerramentaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            posicaoFerramentaLabel.Location = new Point(404, 9);
            posicaoFerramentaLabel.Name = "posicaoFerramentaLabel";
            posicaoFerramentaLabel.Size = new Size(335, 41);
            posicaoFerramentaLabel.TabIndex = 35;
            posicaoFerramentaLabel.Text = "Posição de Ferramenta";
            // 
            // posicaoFerramentaNomesFerramentasTextBox
            // 
            posicaoFerramentaNomesFerramentasTextBox.BorderStyle = BorderStyle.FixedSingle;
            posicaoFerramentaNomesFerramentasTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            posicaoFerramentaNomesFerramentasTextBox.Location = new Point(258, 91);
            posicaoFerramentaNomesFerramentasTextBox.Name = "posicaoFerramentaNomesFerramentasTextBox";
            posicaoFerramentaNomesFerramentasTextBox.Size = new Size(627, 27);
            posicaoFerramentaNomesFerramentasTextBox.TabIndex = 33;
            // 
            // posicaoFerramentaNomesFerramentasLabel
            // 
            posicaoFerramentaNomesFerramentasLabel.AutoSize = true;
            posicaoFerramentaNomesFerramentasLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posicaoFerramentaNomesFerramentasLabel.Location = new Point(31, 90);
            posicaoFerramentaNomesFerramentasLabel.Name = "posicaoFerramentaNomesFerramentasLabel";
            posicaoFerramentaNomesFerramentasLabel.Size = new Size(221, 28);
            posicaoFerramentaNomesFerramentasLabel.TabIndex = 34;
            posicaoFerramentaNomesFerramentasLabel.Text = "Nomes das Ferramentas";
            // 
            // PosicaoFerramentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 620);
            Controls.Add(posicaoFerramentaDataGridView);
            Controls.Add(posicaoEstoqueBuscarButton);
            Controls.Add(posicaoFerramentaCodigosFerramentasTextBox);
            Controls.Add(posicaoFerramentaCodigosFerramentasLabel);
            Controls.Add(posicaoFerramentaLabel);
            Controls.Add(posicaoFerramentaNomesFerramentasTextBox);
            Controls.Add(posicaoFerramentaNomesFerramentasLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PosicaoFerramentaForm";
            Text = "Posicao de Ferramenta";
            ((System.ComponentModel.ISupportInitialize)posicaoFerramentaDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView posicaoFerramentaDataGridView;
        private Button posicaoEstoqueBuscarButton;
        private TextBox posicaoFerramentaCodigosFerramentasTextBox;
        private Label posicaoFerramentaCodigosFerramentasLabel;
        private Label posicaoFerramentaLabel;
        private TextBox posicaoFerramentaNomesFerramentasTextBox;
        private Label posicaoFerramentaNomesFerramentasLabel;
    }
}