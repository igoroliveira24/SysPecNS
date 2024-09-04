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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(84, 25);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 25);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 103);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 105);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 105);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 176);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(223, 45);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(230, 23);
            txtRazaoSocial.TabIndex = 8;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(490, 45);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(158, 23);
            txtFantasia.TabIndex = 9;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(88, 123);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(160, 23);
            txtCNPJ.TabIndex = 10;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(281, 123);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(185, 23);
            txtContato.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(490, 123);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(158, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 23);
            txtEmail.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(564, 150);
            dataGridView1.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(391, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "&Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(523, 194);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtContato);
            Controls.Add(txtCNPJ);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
    }
}