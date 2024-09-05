namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            txtCNPJ = new TextBox();
            txtContato = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            dtgFornecedor = new DataGridView();
            identificacao = new DataGridViewTextBoxColumn();
            RznSocial = new DataGridViewTextBoxColumn();
            Fntsia = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            cont = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnConsulta = new Button();
            tabControl1 = new TabControl();
            tabpage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btnAddProdutoFornecedor = new Button();
            txtFornecedorId = new TextBox();
            dtgFornecedor1 = new DataGridView();
            IDFornecedordtg1 = new DataGridViewTextBoxColumn();
            Fant = new DataGridViewTextBoxColumn();
            txtProdutoId = new TextBox();
            dtgProduto = new DataGridView();
            IDProdutodtg1 = new DataGridViewTextBoxColumn();
            CDBar = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label1 = new Label();
            dtgProdutoFornecedor = new DataGridView();
            IDProduto = new DataGridViewTextBoxColumn();
            CodBarra = new DataGridViewTextBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            IDFornecedor = new DataGridViewTextBoxColumn();
            forn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor).BeginInit();
            tabControl1.SuspendLayout();
            tabpage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProdutoFornecedor).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(33, 28);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 28);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 106);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 108);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 108);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 179);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtId
            // 
            txtId.Location = new Point(33, 46);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(172, 48);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(230, 23);
            txtRazaoSocial.TabIndex = 8;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(439, 48);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(158, 23);
            txtFantasia.TabIndex = 9;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(37, 126);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(160, 23);
            txtCNPJ.TabIndex = 10;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(230, 126);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(185, 23);
            txtContato.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(439, 126);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(158, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 23);
            txtEmail.TabIndex = 13;
            // 
            // dtgFornecedor
            // 
            dtgFornecedor.AllowUserToAddRows = false;
            dtgFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFornecedor.Columns.AddRange(new DataGridViewColumn[] { identificacao, RznSocial, Fntsia, cnpj, cont, Tel, mail });
            dtgFornecedor.Location = new Point(33, 281);
            dtgFornecedor.Name = "dtgFornecedor";
            dtgFornecedor.RowHeadersVisible = false;
            dtgFornecedor.Size = new Size(634, 150);
            dtgFornecedor.TabIndex = 14;
            // 
            // identificacao
            // 
            identificacao.Frozen = true;
            identificacao.HeaderText = "ID";
            identificacao.Name = "identificacao";
            identificacao.ReadOnly = true;
            // 
            // RznSocial
            // 
            RznSocial.HeaderText = "Razão Social";
            RznSocial.Name = "RznSocial";
            RznSocial.ReadOnly = true;
            // 
            // Fntsia
            // 
            Fntsia.HeaderText = "Fantasia";
            Fntsia.Name = "Fntsia";
            Fntsia.ReadOnly = true;
            // 
            // cnpj
            // 
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            // 
            // cont
            // 
            cont.HeaderText = "Contato";
            cont.Name = "cont";
            cont.ReadOnly = true;
            // 
            // Tel
            // 
            Tel.HeaderText = "Telefone";
            Tel.Name = "Tel";
            Tel.ReadOnly = true;
            // 
            // mail
            // 
            mail.HeaderText = "Email";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(340, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "&Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(466, 197);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(592, 197);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(75, 23);
            btnConsulta.TabIndex = 21;
            btnConsulta.Text = "&Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(33, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(731, 579);
            tabControl1.TabIndex = 22;
            // 
            // tabpage1
            // 
            tabpage1.Controls.Add(dtgFornecedor);
            tabpage1.Controls.Add(btnConsulta);
            tabpage1.Controls.Add(ID);
            tabpage1.Controls.Add(btnUpdate);
            tabpage1.Controls.Add(label2);
            tabpage1.Controls.Add(btnAdd);
            tabpage1.Controls.Add(label3);
            tabpage1.Controls.Add(label4);
            tabpage1.Controls.Add(txtEmail);
            tabpage1.Controls.Add(label5);
            tabpage1.Controls.Add(txtTelefone);
            tabpage1.Controls.Add(label6);
            tabpage1.Controls.Add(txtContato);
            tabpage1.Controls.Add(label7);
            tabpage1.Controls.Add(txtCNPJ);
            tabpage1.Controls.Add(txtId);
            tabpage1.Controls.Add(txtFantasia);
            tabpage1.Controls.Add(txtRazaoSocial);
            tabpage1.Location = new Point(4, 24);
            tabpage1.Name = "tabpage1";
            tabpage1.Padding = new Padding(3);
            tabpage1.Size = new Size(723, 551);
            tabpage1.TabIndex = 0;
            tabpage1.Text = "Fornecedor";
            tabpage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dtgProdutoFornecedor);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(723, 551);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Produtos do Fornecedor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProdutoFornecedor);
            groupBox1.Controls.Add(txtFornecedorId);
            groupBox1.Controls.Add(dtgFornecedor1);
            groupBox1.Controls.Add(txtProdutoId);
            groupBox1.Controls.Add(dtgProduto);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(53, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 330);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddProdutoFornecedor
            // 
            btnAddProdutoFornecedor.Location = new Point(21, 284);
            btnAddProdutoFornecedor.Name = "btnAddProdutoFornecedor";
            btnAddProdutoFornecedor.Size = new Size(75, 23);
            btnAddProdutoFornecedor.TabIndex = 8;
            btnAddProdutoFornecedor.Text = "&Adicionar";
            btnAddProdutoFornecedor.UseVisualStyleBackColor = true;
            btnAddProdutoFornecedor.Click += btnAddProdutoFornecedor_Click;
            // 
            // txtFornecedorId
            // 
            txtFornecedorId.Location = new Point(343, 58);
            txtFornecedorId.Name = "txtFornecedorId";
            txtFornecedorId.Size = new Size(100, 23);
            txtFornecedorId.TabIndex = 7;
            // 
            // dtgFornecedor1
            // 
            dtgFornecedor1.AllowUserToAddRows = false;
            dtgFornecedor1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFornecedor1.Columns.AddRange(new DataGridViewColumn[] { IDFornecedordtg1, Fant });
            dtgFornecedor1.Location = new Point(343, 105);
            dtgFornecedor1.Name = "dtgFornecedor1";
            dtgFornecedor1.RowHeadersVisible = false;
            dtgFornecedor1.Size = new Size(238, 150);
            dtgFornecedor1.TabIndex = 6;
            // 
            // IDFornecedordtg1
            // 
            IDFornecedordtg1.Frozen = true;
            IDFornecedordtg1.HeaderText = "ID";
            IDFornecedordtg1.Name = "IDFornecedordtg1";
            IDFornecedordtg1.ReadOnly = true;
            // 
            // Fant
            // 
            Fant.HeaderText = "Nome Fantasia";
            Fant.Name = "Fant";
            Fant.ReadOnly = true;
            Fant.Width = 135;
            // 
            // txtProdutoId
            // 
            txtProdutoId.Location = new Point(21, 58);
            txtProdutoId.Name = "txtProdutoId";
            txtProdutoId.Size = new Size(100, 23);
            txtProdutoId.TabIndex = 4;
            // 
            // dtgProduto
            // 
            dtgProduto.AllowUserToAddRows = false;
            dtgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduto.Columns.AddRange(new DataGridViewColumn[] { IDProdutodtg1, CDBar, Descricao });
            dtgProduto.Location = new Point(21, 105);
            dtgProduto.Name = "dtgProduto";
            dtgProduto.RowHeadersVisible = false;
            dtgProduto.Size = new Size(240, 150);
            dtgProduto.TabIndex = 3;
            // 
            // IDProdutodtg1
            // 
            IDProdutodtg1.Frozen = true;
            IDProdutodtg1.HeaderText = "ID";
            IDProdutodtg1.Name = "IDProdutodtg1";
            IDProdutodtg1.ReadOnly = true;
            // 
            // CDBar
            // 
            CDBar.HeaderText = "Codigo de Barra";
            CDBar.Name = "CDBar";
            CDBar.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 23);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 2;
            label8.Text = "ID do Fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Id do Produto";
            label1.Click += label1_Click;
            // 
            // dtgProdutoFornecedor
            // 
            dtgProdutoFornecedor.AllowUserToAddRows = false;
            dtgProdutoFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProdutoFornecedor.Columns.AddRange(new DataGridViewColumn[] { IDProduto, CodBarra, Desc, IDFornecedor, forn });
            dtgProdutoFornecedor.Location = new Point(100, 370);
            dtgProdutoFornecedor.Name = "dtgProdutoFornecedor";
            dtgProdutoFornecedor.RowHeadersVisible = false;
            dtgProdutoFornecedor.Size = new Size(503, 150);
            dtgProdutoFornecedor.TabIndex = 0;
            // 
            // IDProduto
            // 
            IDProduto.HeaderText = "ID do Produto";
            IDProduto.Name = "IDProduto";
            IDProduto.ReadOnly = true;
            IDProduto.Width = 150;
            // 
            // CodBarra
            // 
            CodBarra.HeaderText = "Codigo de Barras";
            CodBarra.Name = "CodBarra";
            CodBarra.ReadOnly = true;
            // 
            // Desc
            // 
            Desc.HeaderText = "Descricao";
            Desc.Name = "Desc";
            Desc.ReadOnly = true;
            Desc.Width = 150;
            // 
            // IDFornecedor
            // 
            IDFornecedor.HeaderText = "ID do Fornecedor";
            IDFornecedor.Name = "IDFornecedor";
            IDFornecedor.ReadOnly = true;
            // 
            // forn
            // 
            forn.HeaderText = "Nome Fantasia";
            forn.Name = "forn";
            forn.ReadOnly = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 603);
            Controls.Add(tabControl1);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor).EndInit();
            tabControl1.ResumeLayout(false);
            tabpage1.ResumeLayout(false);
            tabpage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFornecedor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProdutoFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private TextBox txtCNPJ;
        private TextBox txtContato;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private DataGridView dtgFornecedor;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnConsulta;
        private TabControl tabControl1;
        private TabPage tabpage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn identificacao;
        private DataGridViewTextBoxColumn RznSocial;
        private DataGridViewTextBoxColumn Fntsia;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn cont;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn mail;
        private DataGridView dtgProdutoFornecedor;
        private GroupBox groupBox1;
        private DataGridView dtgFornecedor1;
        private TextBox textBox2;
        private TextBox txtProdutoId;
        private DataGridView dtgProduto;
        private Label label8;
        private Label label1;
        private DataGridViewTextBoxColumn IDFornecedordtg1;
        private DataGridViewTextBoxColumn Fant;
        private DataGridViewTextBoxColumn IDProdutodtg1;
        private DataGridViewTextBoxColumn CDBar;
        private DataGridViewTextBoxColumn Descricao;
        private TextBox txtFornecedorId;
        private Button btnAddProdutoFornecedor;
        private DataGridViewTextBoxColumn IDProduto;
        private DataGridViewTextBoxColumn CodBarra;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn IDFornecedor;
        private DataGridViewTextBoxColumn forn;
    }
}