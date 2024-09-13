namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            txtProdutoId = new TextBox();
            txtDescricao = new TextBox();
            nudQuantidade = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuantidade = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Dum = new DataGridViewTextBoxColumn();
            btnAltera = new Button();
            btnCancelaAlteracao = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtProdutoId
            // 
            txtProdutoId.Location = new Point(60, 45);
            txtProdutoId.Name = "txtProdutoId";
            txtProdutoId.ReadOnly = true;
            txtProdutoId.Size = new Size(100, 23);
            txtProdutoId.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(60, 97);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(232, 23);
            txtDescricao.TabIndex = 1;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(166, 139);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(55, 23);
            nudQuantidade.TabIndex = 2;
            nudQuantidade.ValueChanged += nudQuantidade_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 79);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(60, 139);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.ReadOnly = true;
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Descricao, Quantidade, Dum });
            dataGridView1.Location = new Point(60, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(650, 213);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.Frozen = true;
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 250;
            // 
            // Quantidade
            // 
            Quantidade.Frozen = true;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Dum
            // 
            Dum.Frozen = true;
            Dum.HeaderText = "Data do ultimo movimento";
            Dum.Name = "Dum";
            Dum.ReadOnly = true;
            Dum.Width = 200;
            // 
            // btnAltera
            // 
            btnAltera.Enabled = false;
            btnAltera.Location = new Point(243, 139);
            btnAltera.Name = "btnAltera";
            btnAltera.Size = new Size(75, 23);
            btnAltera.TabIndex = 8;
            btnAltera.Text = "Alterar";
            btnAltera.UseVisualStyleBackColor = true;
            btnAltera.Click += btnAltera_Click;
            // 
            // btnCancelaAlteracao
            // 
            btnCancelaAlteracao.Location = new Point(340, 139);
            btnCancelaAlteracao.Name = "btnCancelaAlteracao";
            btnCancelaAlteracao.Size = new Size(75, 23);
            btnCancelaAlteracao.TabIndex = 9;
            btnCancelaAlteracao.Text = "Cancelar";
            btnCancelaAlteracao.UseVisualStyleBackColor = true;
            btnCancelaAlteracao.Click += btnCancelaAlteracao_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(650, 23);
            textBox1.TabIndex = 10;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnCancelaAlteracao);
            Controls.Add(btnAltera);
            Controls.Add(dataGridView1);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudQuantidade);
            Controls.Add(txtDescricao);
            Controls.Add(txtProdutoId);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProdutoId;
        private TextBox txtDescricao;
        private NumericUpDown nudQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuantidade;
        private DataGridView dataGridView1;
        private Button btnAltera;
        private Button btnCancelaAlteracao;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Dum;
    }
}