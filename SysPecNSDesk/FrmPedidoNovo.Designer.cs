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
            groupBox1 = new GroupBox();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            label4 = new Label();
            txtNomeCliente = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInserePedido);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(28, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(460, 91);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(87, 29);
            btnInserePedido.TabIndex = 5;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 12F);
            txtIdCliente.Location = new Point(99, 91);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(83, 29);
            txtIdCliente.TabIndex = 4;
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
            txtNomeCliente.Size = new Size(247, 29);
            txtNomeCliente.TabIndex = 2;
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
            txtUsuario.Size = new Size(336, 29);
            txtUsuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(28, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens do Pedido";
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
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 616);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtNomeCliente;
        private TextBox txtIdCliente;
        private Label label4;
        private Button btnInserePedido;
    }
}