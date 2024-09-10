namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label4 = new Label();
            txtNomeCliente = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            grbItens = new GroupBox();
            txtCodBar = new TextBox();
            txtTotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItens = new TextBox();
            txtQuantidadeItem = new TextBox();
            txtValorUnitItem = new TextBox();
            txtDescricaoItem = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            txtDescontodoPedido = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label11 = new Label();
            escontoItem = new Label();
            DescontoPedido = new Label();
            txt = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(txtNomeCliente);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Location = new Point(28, 57);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(623, 145);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            grbIdentificacao.Enter += groupBox1_Enter;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(497, 44);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(87, 58);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 12F);
            txtIdCliente.Location = new Point(99, 91);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(83, 29);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(22, 95);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 12F);
            txtNomeCliente.Location = new Point(188, 91);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(274, 29);
            txtNomeCliente.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(22, 44);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(99, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(363, 29);
            txtUsuario.TabIndex = 0;
            // 
            // grbItens
            // 
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItens);
            grbItens.Controls.Add(txtQuantidadeItem);
            grbItens.Controls.Add(txtValorUnitItem);
            grbItens.Controls.Add(txtDescricaoItem);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(28, 227);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(623, 284);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(22, 38);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(116, 23);
            txtCodBar.TabIndex = 14;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = SystemColors.ControlText;
            txtTotal.Location = new Point(475, 237);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(132, 33);
            txtTotal.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(397, 240);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(439, 20);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 20);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(310, 20);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 20);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 8;
            label6.Text = "Decrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de barras";
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(439, 38);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.RightToLeft = RightToLeft.Yes;
            txtDescontoItens.Size = new Size(85, 23);
            txtDescontoItens.TabIndex = 4;
            txtDescontoItens.Text = "0";
            // 
            // txtQuantidadeItem
            // 
            txtQuantidadeItem.Location = new Point(372, 38);
            txtQuantidadeItem.Name = "txtQuantidadeItem";
            txtQuantidadeItem.RightToLeft = RightToLeft.Yes;
            txtQuantidadeItem.Size = new Size(61, 23);
            txtQuantidadeItem.TabIndex = 3;
            txtQuantidadeItem.Text = "1";
            // 
            // txtValorUnitItem
            // 
            txtValorUnitItem.Location = new Point(310, 38);
            txtValorUnitItem.Name = "txtValorUnitItem";
            txtValorUnitItem.Size = new Size(56, 23);
            txtValorUnitItem.TabIndex = 2;
            // 
            // txtDescricaoItem
            // 
            txtDescricaoItem.Location = new Point(144, 38);
            txtDescricaoItem.Name = "txtDescricaoItem";
            txtDescricaoItem.Size = new Size(160, 23);
            txtDescricaoItem.TabIndex = 1;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(530, 23);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 38);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(3, 85);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(620, 146);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 180;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 60;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("News701 BT", 26F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(127, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 42);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(525, 5);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 3;
            label2.Text = "Numero:";
            label2.Click += label2_Click;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(624, 12);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(200, 23);
            txtIdPedido.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(668, 318);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(668, 424);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(146, 29);
            textBox4.TabIndex = 7;
            // 
            // txtDescontodoPedido
            // 
            txtDescontodoPedido.Location = new Point(668, 371);
            txtDescontodoPedido.Name = "txtDescontodoPedido";
            txtDescontodoPedido.Size = new Size(146, 23);
            txtDescontodoPedido.TabIndex = 8;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(698, 471);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(85, 40);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(668, 265);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(146, 23);
            txtSubTotal.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(715, 247);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 11;
            label11.Text = "SubTotal";
            // 
            // escontoItem
            // 
            escontoItem.AutoSize = true;
            escontoItem.Location = new Point(698, 300);
            escontoItem.Name = "escontoItem";
            escontoItem.Size = new Size(85, 15);
            escontoItem.TabIndex = 12;
            escontoItem.Text = "Desconto Itens";
            // 
            // DescontoPedido
            // 
            DescontoPedido.AutoSize = true;
            DescontoPedido.Location = new Point(680, 353);
            DescontoPedido.Name = "DescontoPedido";
            DescontoPedido.Size = new Size(114, 15);
            DescontoPedido.TabIndex = 13;
            DescontoPedido.Text = "Desconto do pedido";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt.Location = new Point(725, 408);
            txt.Name = "txt";
            txt.Size = new Size(32, 15);
            txt.TabIndex = 14;
            txt.Text = "Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 528);
            Controls.Add(txt);
            Controls.Add(DescontoPedido);
            Controls.Add(escontoItem);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(btnFechar);
            Controls.Add(txtDescontodoPedido);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtNomeCliente;
        private TextBox txtIdCliente;
        private Label label4;
        private Button btnInserePedido;
        private DataGridView dgvItensPedido;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItens;
        private TextBox txtQuantidadeItem;
        private TextBox txtValorUnitItem;
        private TextBox txtDescricaoItem;
        private Button btnAddItem;
        private Label label9;
        private Label label8;
        private TextBox txtTotal;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox txtDescontodoPedido;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label11;
        private Label escontoItem;
        private Label DescontoPedido;
        private Label txt;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private TextBox txtCodBar;
    }
}