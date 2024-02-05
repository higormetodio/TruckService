namespace TruckService
{
    partial class CentralForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralForm));
            pictureBox1 = new PictureBox();
            cadastroContextMenuStrip = new ContextMenuStrip(components);
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarMenuStrip = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            ferramentaToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            ordemServicoToolStripMenuItem = new ToolStripMenuItem();
            pedidoVendaToolStripMenuItem = new ToolStripMenuItem();
            orcamentoServicoToolStripMenuItem = new ToolStripMenuItem();
            orcamentoVendaToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            posicaoEstoqueToolStripMenuItem = new ToolStripMenuItem();
            posicaoFerramentasToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            ordensDeServicoToolStripMenuItem = new ToolStripMenuItem();
            pedidosDeVendaToolStripMenuItem = new ToolStripMenuItem();
            orcamentosDeServicoToolStripMenuItem = new ToolStripMenuItem();
            orcamentosDeVendaToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cadastroContextMenuStrip.SuspendLayout();
            cadastrarMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.truck;
            pictureBox1.Location = new Point(320, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cadastroContextMenuStrip
            // 
            cadastroContextMenuStrip.ImageScalingSize = new Size(20, 20);
            cadastroContextMenuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            cadastroContextMenuStrip.Name = "cadastroContextMenuStrip";
            cadastroContextMenuStrip.Size = new Size(144, 28);
            cadastroContextMenuStrip.Text = "Cadastros";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(143, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarMenuStrip
            // 
            cadastrarMenuStrip.ImageScalingSize = new Size(20, 20);
            cadastrarMenuStrip.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, inserirToolStripMenuItem, estoqueToolStripMenuItem, relatoriosToolStripMenuItem, listarToolStripMenuItem });
            cadastrarMenuStrip.Location = new Point(0, 0);
            cadastrarMenuStrip.Name = "cadastrarMenuStrip";
            cadastrarMenuStrip.Size = new Size(1171, 28);
            cadastrarMenuStrip.TabIndex = 1;
            cadastrarMenuStrip.Text = "Cadastrar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionarioToolStripMenuItem, clienteToolStripMenuItem, fornecedorToolStripMenuItem, categoriaToolStripMenuItem, produtoToolStripMenuItem, ferramentaToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(169, 26);
            funcionarioToolStripMenuItem.Text = "Funcionário";
            funcionarioToolStripMenuItem.Click += funcionarioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(169, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(169, 26);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            fornecedorToolStripMenuItem.Click += fornecedorToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(169, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(169, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // ferramentaToolStripMenuItem
            // 
            ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            ferramentaToolStripMenuItem.Size = new Size(169, 26);
            ferramentaToolStripMenuItem.Text = "Ferramenta";
            ferramentaToolStripMenuItem.Click += ferramentaToolStripMenuItem_Click;
            // 
            // inserirToolStripMenuItem
            // 
            inserirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordemServicoToolStripMenuItem, pedidoVendaToolStripMenuItem, orcamentoServicoToolStripMenuItem, orcamentoVendaToolStripMenuItem });
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            inserirToolStripMenuItem.Size = new Size(63, 24);
            inserirToolStripMenuItem.Text = "Inserir";
            // 
            // ordemServicoToolStripMenuItem
            // 
            ordemServicoToolStripMenuItem.Name = "ordemServicoToolStripMenuItem";
            ordemServicoToolStripMenuItem.Size = new Size(239, 26);
            ordemServicoToolStripMenuItem.Text = "Ordem de Serviço";
            ordemServicoToolStripMenuItem.Click += ordemServicoToolStripMenuItem_Click;
            // 
            // pedidoVendaToolStripMenuItem
            // 
            pedidoVendaToolStripMenuItem.Name = "pedidoVendaToolStripMenuItem";
            pedidoVendaToolStripMenuItem.Size = new Size(239, 26);
            pedidoVendaToolStripMenuItem.Text = "Pedido de Venda";
            pedidoVendaToolStripMenuItem.Click += pedidoVendaToolStripMenuItem_Click;
            // 
            // orcamentoServicoToolStripMenuItem
            // 
            orcamentoServicoToolStripMenuItem.Name = "orcamentoServicoToolStripMenuItem";
            orcamentoServicoToolStripMenuItem.Size = new Size(239, 26);
            orcamentoServicoToolStripMenuItem.Text = "Orçamento de Serviço";
            orcamentoServicoToolStripMenuItem.Click += orcamentoServicoToolStripMenuItem_Click;
            // 
            // orcamentoVendaToolStripMenuItem
            // 
            orcamentoVendaToolStripMenuItem.Name = "orcamentoVendaToolStripMenuItem";
            orcamentoVendaToolStripMenuItem.Size = new Size(239, 26);
            orcamentoVendaToolStripMenuItem.Text = "Orçamento de Venda";
            orcamentoVendaToolStripMenuItem.Click += orcamentoVendaToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { posicaoEstoqueToolStripMenuItem, posicaoFerramentasToolStripMenuItem });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(76, 24);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // posicaoEstoqueToolStripMenuItem
            // 
            posicaoEstoqueToolStripMenuItem.Name = "posicaoEstoqueToolStripMenuItem";
            posicaoEstoqueToolStripMenuItem.Size = new Size(242, 26);
            posicaoEstoqueToolStripMenuItem.Text = "Posicao Estoque";
            posicaoEstoqueToolStripMenuItem.Click += posicaoEstoqueToolStripMenuItem_Click;
            // 
            // posicaoFerramentasToolStripMenuItem
            // 
            posicaoFerramentasToolStripMenuItem.Name = "posicaoFerramentasToolStripMenuItem";
            posicaoFerramentasToolStripMenuItem.Size = new Size(242, 26);
            posicaoFerramentasToolStripMenuItem.Text = "Posição de Ferramenta";
            posicaoFerramentasToolStripMenuItem.Click += listarFerramentasToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordensDeServicoToolStripMenuItem, pedidosDeVendaToolStripMenuItem, orcamentosDeServicoToolStripMenuItem, orcamentosDeVendaToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(90, 24);
            relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // ordensDeServicoToolStripMenuItem
            // 
            ordensDeServicoToolStripMenuItem.Name = "ordensDeServicoToolStripMenuItem";
            ordensDeServicoToolStripMenuItem.Size = new Size(245, 26);
            ordensDeServicoToolStripMenuItem.Text = "Ordens de Serviço";
            // 
            // pedidosDeVendaToolStripMenuItem
            // 
            pedidosDeVendaToolStripMenuItem.Name = "pedidosDeVendaToolStripMenuItem";
            pedidosDeVendaToolStripMenuItem.Size = new Size(245, 26);
            pedidosDeVendaToolStripMenuItem.Text = "Pedidos de Venda";
            // 
            // orcamentosDeServicoToolStripMenuItem
            // 
            orcamentosDeServicoToolStripMenuItem.Name = "orcamentosDeServicoToolStripMenuItem";
            orcamentosDeServicoToolStripMenuItem.Size = new Size(245, 26);
            orcamentosDeServicoToolStripMenuItem.Text = "Orçamentos de Serviço";
            // 
            // orcamentosDeVendaToolStripMenuItem
            // 
            orcamentosDeVendaToolStripMenuItem.Name = "orcamentosDeVendaToolStripMenuItem";
            orcamentosDeVendaToolStripMenuItem.Size = new Size(245, 26);
            orcamentosDeVendaToolStripMenuItem.Text = "Orçamentos de Venda";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionarioToolStripMenuItem1 });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(58, 24);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // funcionarioToolStripMenuItem1
            // 
            funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            funcionarioToolStripMenuItem1.Size = new Size(224, 26);
            funcionarioToolStripMenuItem1.Text = "Funcionario";
            funcionarioToolStripMenuItem1.Click += funcionarioToolStripMenuItem1_Click;
            // 
            // CentralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 668);
            Controls.Add(cadastrarMenuStrip);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = cadastrarMenuStrip;
            Name = "CentralForm";
            Text = "Truck Service";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cadastroContextMenuStrip.ResumeLayout(false);
            cadastrarMenuStrip.ResumeLayout(false);
            cadastrarMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ContextMenuStrip cadastroContextMenuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private MenuStrip cadastrarMenuStrip;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem ferramentaToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem orcamentoServicoToolStripMenuItem;
        private ToolStripMenuItem orcamentoVendaToolStripMenuItem;
        private ToolStripMenuItem ordemServicoToolStripMenuItem;
        private ToolStripMenuItem pedidoVendaToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem posicaoEstoqueToolStripMenuItem;
        private ToolStripMenuItem posicaoFerramentasToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem ordensDeServicoToolStripMenuItem;
        private ToolStripMenuItem pedidosDeVendaToolStripMenuItem;
        private ToolStripMenuItem orcamentosDeServicoToolStripMenuItem;
        private ToolStripMenuItem orcamentosDeVendaToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem1;
    }
}
