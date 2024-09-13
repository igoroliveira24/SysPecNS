namespace SysPecNSDesk
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem3 = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem4 = new ToolStripMenuItem();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            listaToolStripMenuItem1 = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, movimentoToolStripMenuItem, operaçãoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtoToolStripMenuItem, usuariosToolStripMenuItem, fornecedorToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, listaToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(103, 22);
            novoToolStripMenuItem.Text = "&Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(103, 22);
            listaToolStripMenuItem.Text = "&Lista";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2, listaToolStripMenuItem1, estoqueToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(180, 22);
            produtoToolStripMenuItem.Text = "&Produto";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(180, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            novoToolStripMenuItem2.Click += novoToolStripMenuItem2_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(103, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem3 });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(180, 22);
            fornecedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // novoToolStripMenuItem3
            // 
            novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            novoToolStripMenuItem3.Size = new Size(103, 22);
            novoToolStripMenuItem3.Text = "&Novo";
            novoToolStripMenuItem3.Click += novoToolStripMenuItem3_Click;
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem4 });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(180, 22);
            pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // novoToolStripMenuItem4
            // 
            novoToolStripMenuItem4.Name = "novoToolStripMenuItem4";
            novoToolStripMenuItem4.Size = new Size(180, 22);
            novoToolStripMenuItem4.Text = "Novo";
            novoToolStripMenuItem4.Click += novoToolStripMenuItem4_Click;
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(180, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // listaToolStripMenuItem1
            // 
            listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            listaToolStripMenuItem1.Size = new Size(180, 22);
            listaToolStripMenuItem1.Text = "Lista";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem2 });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(180, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // listaToolStripMenuItem2
            // 
            listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            listaToolStripMenuItem2.Size = new Size(180, 22);
            listaToolStripMenuItem2.Text = "Lista";
            listaToolStripMenuItem2.Click += listaToolStripMenuItem2_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Sistema de Controle de Loja";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem novoToolStripMenuItem4;
        private ToolStripMenuItem listaToolStripMenuItem1;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem2;
    }
}