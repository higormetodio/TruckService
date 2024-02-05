using System.Globalization;

namespace TruckService
{
    partial class FuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionarioForm));
            cadastroFuncionarioLabel = new Label();
            cadastroFuncionarioSalvarButton = new Button();
            cadastroFuncionarioAlterarButton = new Button();
            cadastroFuncionarioDeletarButton = new Button();
            cadastroFuncionarioLogradouroLabel = new Label();
            cadastroFuncionarioNumeroLabel = new Label();
            cadastroFuncionarioCepMaskedTextBox = new MaskedTextBox();
            cadastroFuncionarioNumeroTextBox = new TextBox();
            cadastroFuncionarioCepLabel = new Label();
            cadastroFuncionarioBairroLabel = new Label();
            cadastroFuncionarioEmailTextBox = new TextBox();
            cadastroFuncionarioBairroTextBox = new TextBox();
            cadastroFuncionarioEmailLabel = new Label();
            cadastroFuncionarioCidadeLabel = new Label();
            cadastroFuncionarioTelefoneMaskedTextBox = new MaskedTextBox();
            cadastroFuncionarioCidadeTextBox = new TextBox();
            cadastroFuncionarioTelefoneLabel = new Label();
            cadastroFuncionarioUfLabel = new Label();
            cadastroFuncionarioCpfMaskedTextBox = new MaskedTextBox();
            cadastroFuncionarioDataNascimentoLabel = new Label();
            cadastroFuncionarioUfTextBox = new TextBox();
            cadastroFuncionarioDataNascimentoDateTimePicker = new DateTimePicker();
            cadastroFuncionarioCpfLabel = new Label();
            cadastroFuncionarioNomeTextBox = new TextBox();
            cadastroFuncionarioNomeLabel = new Label();
            cadastroFuncionarioLogradouroTextBox = new TextBox();
            cadastroFuncionarioFerramentasButton = new Button();
            cadastroFuncionarioSalvarAlteracaoButton = new Button();
            SuspendLayout();
            // 
            // cadastroFuncionarioLabel
            // 
            cadastroFuncionarioLabel.AutoSize = true;
            cadastroFuncionarioLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroFuncionarioLabel.Location = new Point(407, 9);
            cadastroFuncionarioLabel.Name = "cadastroFuncionarioLabel";
            cadastroFuncionarioLabel.Size = new Size(360, 41);
            cadastroFuncionarioLabel.TabIndex = 0;
            cadastroFuncionarioLabel.Text = "Cadastro de Funcionário";
            // 
            // cadastroFuncionarioSalvarButton
            // 
            cadastroFuncionarioSalvarButton.Location = new Point(396, 597);
            cadastroFuncionarioSalvarButton.Name = "cadastroFuncionarioSalvarButton";
            cadastroFuncionarioSalvarButton.Size = new Size(104, 39);
            cadastroFuncionarioSalvarButton.TabIndex = 12;
            cadastroFuncionarioSalvarButton.Text = "Salvar";
            cadastroFuncionarioSalvarButton.UseVisualStyleBackColor = true;
            cadastroFuncionarioSalvarButton.Click += cadastroFuncionarioSalvarButton_Click;
            // 
            // cadastroFuncionarioAlterarButton
            // 
            cadastroFuncionarioAlterarButton.Enabled = false;
            cadastroFuncionarioAlterarButton.Location = new Point(534, 597);
            cadastroFuncionarioAlterarButton.Name = "cadastroFuncionarioAlterarButton";
            cadastroFuncionarioAlterarButton.Size = new Size(104, 39);
            cadastroFuncionarioAlterarButton.TabIndex = 13;
            cadastroFuncionarioAlterarButton.Text = "Alterar";
            cadastroFuncionarioAlterarButton.UseVisualStyleBackColor = true;
            cadastroFuncionarioAlterarButton.Click += cadastroFuncionarioAlterarButton_Click;
            // 
            // cadastroFuncionarioDeletarButton
            // 
            cadastroFuncionarioDeletarButton.Enabled = false;
            cadastroFuncionarioDeletarButton.Location = new Point(1024, 597);
            cadastroFuncionarioDeletarButton.Name = "cadastroFuncionarioDeletarButton";
            cadastroFuncionarioDeletarButton.Size = new Size(104, 39);
            cadastroFuncionarioDeletarButton.TabIndex = 16;
            cadastroFuncionarioDeletarButton.Text = "Deletar";
            cadastroFuncionarioDeletarButton.UseVisualStyleBackColor = true;
            cadastroFuncionarioDeletarButton.Click += cadastroFuncionarioDeletarButton_Click;
            // 
            // cadastroFuncionarioLogradouroLabel
            // 
            cadastroFuncionarioLogradouroLabel.AutoSize = true;
            cadastroFuncionarioLogradouroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioLogradouroLabel.Location = new Point(10, 304);
            cadastroFuncionarioLogradouroLabel.Name = "cadastroFuncionarioLogradouroLabel";
            cadastroFuncionarioLogradouroLabel.Size = new Size(116, 28);
            cadastroFuncionarioLogradouroLabel.TabIndex = 14;
            cadastroFuncionarioLogradouroLabel.Text = "Logradouro";
            // 
            // cadastroFuncionarioNumeroLabel
            // 
            cadastroFuncionarioNumeroLabel.AutoSize = true;
            cadastroFuncionarioNumeroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioNumeroLabel.Location = new Point(42, 348);
            cadastroFuncionarioNumeroLabel.Name = "cadastroFuncionarioNumeroLabel";
            cadastroFuncionarioNumeroLabel.Size = new Size(84, 28);
            cadastroFuncionarioNumeroLabel.TabIndex = 16;
            cadastroFuncionarioNumeroLabel.Text = "Número";
            // 
            // cadastroFuncionarioCepMaskedTextBox
            // 
            cadastroFuncionarioCepMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioCepMaskedTextBox.Culture = new CultureInfo("en-US");
            cadastroFuncionarioCepMaskedTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioCepMaskedTextBox.Location = new Point(132, 261);
            cadastroFuncionarioCepMaskedTextBox.Mask = "00.000-000";
            cadastroFuncionarioCepMaskedTextBox.Name = "cadastroFuncionarioCepMaskedTextBox";
            cadastroFuncionarioCepMaskedTextBox.Size = new Size(146, 27);
            cadastroFuncionarioCepMaskedTextBox.TabIndex = 6;
            cadastroFuncionarioCepMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cadastroFuncionarioNumeroTextBox
            // 
            cadastroFuncionarioNumeroTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioNumeroTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioNumeroTextBox.Location = new Point(132, 349);
            cadastroFuncionarioNumeroTextBox.Name = "cadastroFuncionarioNumeroTextBox";
            cadastroFuncionarioNumeroTextBox.Size = new Size(315, 27);
            cadastroFuncionarioNumeroTextBox.TabIndex = 8;
            // 
            // cadastroFuncionarioCepLabel
            // 
            cadastroFuncionarioCepLabel.AutoSize = true;
            cadastroFuncionarioCepLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioCepLabel.Location = new Point(81, 260);
            cadastroFuncionarioCepLabel.Name = "cadastroFuncionarioCepLabel";
            cadastroFuncionarioCepLabel.Size = new Size(45, 28);
            cadastroFuncionarioCepLabel.TabIndex = 12;
            cadastroFuncionarioCepLabel.Text = "CEP";
            // 
            // cadastroFuncionarioBairroLabel
            // 
            cadastroFuncionarioBairroLabel.AutoSize = true;
            cadastroFuncionarioBairroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioBairroLabel.Location = new Point(62, 394);
            cadastroFuncionarioBairroLabel.Name = "cadastroFuncionarioBairroLabel";
            cadastroFuncionarioBairroLabel.Size = new Size(64, 28);
            cadastroFuncionarioBairroLabel.TabIndex = 18;
            cadastroFuncionarioBairroLabel.Text = "Bairro";
            // 
            // cadastroFuncionarioEmailTextBox
            // 
            cadastroFuncionarioEmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioEmailTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioEmailTextBox.Location = new Point(132, 218);
            cadastroFuncionarioEmailTextBox.Name = "cadastroFuncionarioEmailTextBox";
            cadastroFuncionarioEmailTextBox.Size = new Size(315, 27);
            cadastroFuncionarioEmailTextBox.TabIndex = 5;
            // 
            // cadastroFuncionarioBairroTextBox
            // 
            cadastroFuncionarioBairroTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioBairroTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioBairroTextBox.Location = new Point(132, 395);
            cadastroFuncionarioBairroTextBox.Name = "cadastroFuncionarioBairroTextBox";
            cadastroFuncionarioBairroTextBox.Size = new Size(315, 27);
            cadastroFuncionarioBairroTextBox.TabIndex = 9;
            // 
            // cadastroFuncionarioEmailLabel
            // 
            cadastroFuncionarioEmailLabel.AutoSize = true;
            cadastroFuncionarioEmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioEmailLabel.Location = new Point(67, 218);
            cadastroFuncionarioEmailLabel.Name = "cadastroFuncionarioEmailLabel";
            cadastroFuncionarioEmailLabel.Size = new Size(59, 28);
            cadastroFuncionarioEmailLabel.TabIndex = 10;
            cadastroFuncionarioEmailLabel.Text = "Email";
            // 
            // cadastroFuncionarioCidadeLabel
            // 
            cadastroFuncionarioCidadeLabel.AutoSize = true;
            cadastroFuncionarioCidadeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioCidadeLabel.Location = new Point(53, 436);
            cadastroFuncionarioCidadeLabel.Name = "cadastroFuncionarioCidadeLabel";
            cadastroFuncionarioCidadeLabel.Size = new Size(73, 28);
            cadastroFuncionarioCidadeLabel.TabIndex = 20;
            cadastroFuncionarioCidadeLabel.Text = "Cidade";
            // 
            // cadastroFuncionarioTelefoneMaskedTextBox
            // 
            cadastroFuncionarioTelefoneMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioTelefoneMaskedTextBox.Culture = new CultureInfo("en-US");
            cadastroFuncionarioTelefoneMaskedTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioTelefoneMaskedTextBox.Location = new Point(132, 173);
            cadastroFuncionarioTelefoneMaskedTextBox.Mask = "(00)0-0000-0000";
            cadastroFuncionarioTelefoneMaskedTextBox.Name = "cadastroFuncionarioTelefoneMaskedTextBox";
            cadastroFuncionarioTelefoneMaskedTextBox.Size = new Size(146, 27);
            cadastroFuncionarioTelefoneMaskedTextBox.TabIndex = 4;
            cadastroFuncionarioTelefoneMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cadastroFuncionarioCidadeTextBox
            // 
            cadastroFuncionarioCidadeTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioCidadeTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioCidadeTextBox.Location = new Point(132, 437);
            cadastroFuncionarioCidadeTextBox.Name = "cadastroFuncionarioCidadeTextBox";
            cadastroFuncionarioCidadeTextBox.Size = new Size(315, 27);
            cadastroFuncionarioCidadeTextBox.TabIndex = 10;
            // 
            // cadastroFuncionarioTelefoneLabel
            // 
            cadastroFuncionarioTelefoneLabel.AutoSize = true;
            cadastroFuncionarioTelefoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioTelefoneLabel.Location = new Point(42, 172);
            cadastroFuncionarioTelefoneLabel.Name = "cadastroFuncionarioTelefoneLabel";
            cadastroFuncionarioTelefoneLabel.Size = new Size(84, 28);
            cadastroFuncionarioTelefoneLabel.TabIndex = 8;
            cadastroFuncionarioTelefoneLabel.Text = "Telefone";
            // 
            // cadastroFuncionarioUfLabel
            // 
            cadastroFuncionarioUfLabel.AutoSize = true;
            cadastroFuncionarioUfLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioUfLabel.Location = new Point(90, 481);
            cadastroFuncionarioUfLabel.Name = "cadastroFuncionarioUfLabel";
            cadastroFuncionarioUfLabel.Size = new Size(36, 28);
            cadastroFuncionarioUfLabel.TabIndex = 22;
            cadastroFuncionarioUfLabel.Text = "UF";
            // 
            // cadastroFuncionarioCpfMaskedTextBox
            // 
            cadastroFuncionarioCpfMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioCpfMaskedTextBox.Culture = new CultureInfo("en-US");
            cadastroFuncionarioCpfMaskedTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioCpfMaskedTextBox.Location = new Point(132, 127);
            cadastroFuncionarioCpfMaskedTextBox.Mask = "000.000.000-00";
            cadastroFuncionarioCpfMaskedTextBox.Name = "cadastroFuncionarioCpfMaskedTextBox";
            cadastroFuncionarioCpfMaskedTextBox.Size = new Size(146, 27);
            cadastroFuncionarioCpfMaskedTextBox.TabIndex = 3;
            cadastroFuncionarioCpfMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cadastroFuncionarioDataNascimentoLabel
            // 
            cadastroFuncionarioDataNascimentoLabel.AutoSize = true;
            cadastroFuncionarioDataNascimentoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioDataNascimentoLabel.Location = new Point(788, 82);
            cadastroFuncionarioDataNascimentoLabel.Name = "cadastroFuncionarioDataNascimentoLabel";
            cadastroFuncionarioDataNascimentoLabel.Size = new Size(189, 28);
            cadastroFuncionarioDataNascimentoLabel.TabIndex = 3;
            cadastroFuncionarioDataNascimentoLabel.Text = "Data de Nascimento";
            // 
            // cadastroFuncionarioUfTextBox
            // 
            cadastroFuncionarioUfTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioUfTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioUfTextBox.Location = new Point(132, 482);
            cadastroFuncionarioUfTextBox.Name = "cadastroFuncionarioUfTextBox";
            cadastroFuncionarioUfTextBox.Size = new Size(315, 27);
            cadastroFuncionarioUfTextBox.TabIndex = 11;
            // 
            // cadastroFuncionarioDataNascimentoDateTimePicker
            // 
            cadastroFuncionarioDataNascimentoDateTimePicker.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioDataNascimentoDateTimePicker.Format = DateTimePickerFormat.Short;
            cadastroFuncionarioDataNascimentoDateTimePicker.Location = new Point(983, 83);
            cadastroFuncionarioDataNascimentoDateTimePicker.Name = "cadastroFuncionarioDataNascimentoDateTimePicker";
            cadastroFuncionarioDataNascimentoDateTimePicker.Size = new Size(125, 30);
            cadastroFuncionarioDataNascimentoDateTimePicker.TabIndex = 2;
            cadastroFuncionarioDataNascimentoDateTimePicker.Value = new DateTime(2024, 1, 25, 16, 18, 26, 11);
            // 
            // cadastroFuncionarioCpfLabel
            // 
            cadastroFuncionarioCpfLabel.AutoSize = true;
            cadastroFuncionarioCpfLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioCpfLabel.Location = new Point(81, 127);
            cadastroFuncionarioCpfLabel.Name = "cadastroFuncionarioCpfLabel";
            cadastroFuncionarioCpfLabel.Size = new Size(45, 28);
            cadastroFuncionarioCpfLabel.TabIndex = 5;
            cadastroFuncionarioCpfLabel.Text = "CPF";
            // 
            // cadastroFuncionarioNomeTextBox
            // 
            cadastroFuncionarioNomeTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioNomeTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioNomeTextBox.Location = new Point(132, 83);
            cadastroFuncionarioNomeTextBox.Name = "cadastroFuncionarioNomeTextBox";
            cadastroFuncionarioNomeTextBox.Size = new Size(506, 27);
            cadastroFuncionarioNomeTextBox.TabIndex = 1;
            // 
            // cadastroFuncionarioNomeLabel
            // 
            cadastroFuncionarioNomeLabel.AutoSize = true;
            cadastroFuncionarioNomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastroFuncionarioNomeLabel.Location = new Point(60, 83);
            cadastroFuncionarioNomeLabel.Name = "cadastroFuncionarioNomeLabel";
            cadastroFuncionarioNomeLabel.Size = new Size(66, 28);
            cadastroFuncionarioNomeLabel.TabIndex = 1;
            cadastroFuncionarioNomeLabel.Text = "Nome";
            // 
            // cadastroFuncionarioLogradouroTextBox
            // 
            cadastroFuncionarioLogradouroTextBox.BorderStyle = BorderStyle.FixedSingle;
            cadastroFuncionarioLogradouroTextBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            cadastroFuncionarioLogradouroTextBox.Location = new Point(132, 305);
            cadastroFuncionarioLogradouroTextBox.Name = "cadastroFuncionarioLogradouroTextBox";
            cadastroFuncionarioLogradouroTextBox.Size = new Size(514, 27);
            cadastroFuncionarioLogradouroTextBox.TabIndex = 7;
            // 
            // cadastroFuncionarioFerramentasButton
            // 
            cadastroFuncionarioFerramentasButton.Enabled = false;
            cadastroFuncionarioFerramentasButton.Location = new Point(675, 597);
            cadastroFuncionarioFerramentasButton.Name = "cadastroFuncionarioFerramentasButton";
            cadastroFuncionarioFerramentasButton.Size = new Size(104, 39);
            cadastroFuncionarioFerramentasButton.TabIndex = 14;
            cadastroFuncionarioFerramentasButton.Text = "Ferramentas";
            cadastroFuncionarioFerramentasButton.UseVisualStyleBackColor = true;
            cadastroFuncionarioFerramentasButton.Click += cadastroFuncionarioFerramentasButton_Click;
            // 
            // cadastroFuncionarioSalvarAlteracaoButton
            // 
            cadastroFuncionarioSalvarAlteracaoButton.Location = new Point(396, 597);
            cadastroFuncionarioSalvarAlteracaoButton.Name = "cadastroFuncionarioSalvarAlteracaoButton";
            cadastroFuncionarioSalvarAlteracaoButton.Size = new Size(104, 39);
            cadastroFuncionarioSalvarAlteracaoButton.TabIndex = 23;
            cadastroFuncionarioSalvarAlteracaoButton.Text = "Salvar";
            cadastroFuncionarioSalvarAlteracaoButton.UseVisualStyleBackColor = true;
            cadastroFuncionarioSalvarAlteracaoButton.Visible = false;
            cadastroFuncionarioSalvarAlteracaoButton.Click += cadastroFuncionarioSalvarAlteracaoButton_Click;
            // 
            // FuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 668);
            Controls.Add(cadastroFuncionarioSalvarAlteracaoButton);
            Controls.Add(cadastroFuncionarioLogradouroTextBox);
            Controls.Add(cadastroFuncionarioDeletarButton);
            Controls.Add(cadastroFuncionarioNomeLabel);
            Controls.Add(cadastroFuncionarioFerramentasButton);
            Controls.Add(cadastroFuncionarioNomeTextBox);
            Controls.Add(cadastroFuncionarioCpfLabel);
            Controls.Add(cadastroFuncionarioAlterarButton);
            Controls.Add(cadastroFuncionarioDataNascimentoDateTimePicker);
            Controls.Add(cadastroFuncionarioSalvarButton);
            Controls.Add(cadastroFuncionarioUfTextBox);
            Controls.Add(cadastroFuncionarioLabel);
            Controls.Add(cadastroFuncionarioDataNascimentoLabel);
            Controls.Add(cadastroFuncionarioCpfMaskedTextBox);
            Controls.Add(cadastroFuncionarioLogradouroLabel);
            Controls.Add(cadastroFuncionarioUfLabel);
            Controls.Add(cadastroFuncionarioNumeroLabel);
            Controls.Add(cadastroFuncionarioTelefoneLabel);
            Controls.Add(cadastroFuncionarioCepMaskedTextBox);
            Controls.Add(cadastroFuncionarioCidadeTextBox);
            Controls.Add(cadastroFuncionarioNumeroTextBox);
            Controls.Add(cadastroFuncionarioTelefoneMaskedTextBox);
            Controls.Add(cadastroFuncionarioCepLabel);
            Controls.Add(cadastroFuncionarioCidadeLabel);
            Controls.Add(cadastroFuncionarioBairroLabel);
            Controls.Add(cadastroFuncionarioEmailLabel);
            Controls.Add(cadastroFuncionarioEmailTextBox);
            Controls.Add(cadastroFuncionarioBairroTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FuncionarioForm";
            Text = "Funcionario";
            Load += FuncionarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cadastroFuncionarioLabel;
        private Button cadastroFuncionarioSalvarButton;
        private Button cadastroFuncionarioAlterarButton;
        private Button cadastroFuncionarioDeletarButton;
        private Label cadastroFuncionarioLogradouroLabel;
        private Label cadastroFuncionarioNumeroLabel;
        private MaskedTextBox cadastroFuncionarioCepMaskedTextBox;
        private TextBox cadastroFuncionarioNumeroTextBox;
        private Label cadastroFuncionarioCepLabel;
        private Label cadastroFuncionarioBairroLabel;
        private TextBox cadastroFuncionarioEmailTextBox;
        private TextBox cadastroFuncionarioBairroTextBox;
        private Label cadastroFuncionarioEmailLabel;
        private Label cadastroFuncionarioCidadeLabel;
        private MaskedTextBox cadastroFuncionarioTelefoneMaskedTextBox;
        private TextBox cadastroFuncionarioCidadeTextBox;
        private Label cadastroFuncionarioTelefoneLabel;
        private Label cadastroFuncionarioUfLabel;
        private MaskedTextBox cadastroFuncionarioCpfMaskedTextBox;
        private Label cadastroFuncionarioDataNascimentoLabel;
        private TextBox cadastroFuncionarioUfTextBox;
        private DateTimePicker cadastroFuncionarioDataNascimentoDateTimePicker;
        private Label cadastroFuncionarioCpfLabel;
        private TextBox cadastroFuncionarioNomeTextBox;
        private Label cadastroFuncionarioNomeLabel;
        private TextBox cadastroFuncionarioLogradouroTextBox;
        private Button cadastroFuncionarioFerramentasButton;
        private Button cadastroFuncionarioSalvarAlteracaoButton;
    }
}