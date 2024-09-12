namespace SysPecNSDesk
{
    partial class FrmDgvClientesParaPedido
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Data_nasc = new DataGridViewTextBoxColumn();
            Data_cad = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cpf, Telefone, Email, Data_nasc, Data_cad, Ativo });
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(853, 206);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.HeaderText = "NOME";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // Cpf
            // 
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "TELEFONE";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Data_nasc
            // 
            Data_nasc.HeaderText = "Data de Nascimento";
            Data_nasc.Name = "Data_nasc";
            Data_nasc.ReadOnly = true;
            // 
            // Data_cad
            // 
            Data_cad.HeaderText = "Cadastro";
            Data_cad.Name = "Data_cad";
            Data_cad.ReadOnly = true;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(853, 23);
            textBox1.TabIndex = 34;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FrmDgvClientesParaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(879, 395);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "FrmDgvClientesParaPedido";
            Load += FrmDgvClientesParaPedido_Load;
            DoubleClick += FrmDgvClientesParaPedido_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Data_nasc;
        private DataGridViewTextBoxColumn Data_cad;
        private DataGridViewCheckBoxColumn Ativo;
        private TextBox textBox1;
    }
}