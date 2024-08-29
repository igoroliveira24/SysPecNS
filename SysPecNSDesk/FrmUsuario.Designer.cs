namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnInserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkAtivo = new CheckBox();
            txtConfSenha = new TextBox();
            label6 = new Label();
            cmbNivel = new ComboBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtBusca = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(198, 326);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btnInserir
            // 
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 255);
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.Location = new Point(198, 214);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 58);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 25);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 25);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 81);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 81);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "Nível";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 135);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(197, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 11;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(274, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(198, 153);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(90, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(430, 155);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 18;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(304, 153);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 4;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 135);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 17;
            label6.Text = "Confirme a Senha";
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(447, 99);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 2;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(339, 214);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 58);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(480, 214);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 58);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "De&letar";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(198, 306);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 9;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(606, 214);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 58);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(878, 488);
            Controls.Add(btnCancelar);
            Controls.Add(txtBusca);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(cmbNivel);
            Controls.Add(label6);
            Controls.Add(txtConfSenha);
            Controls.Add(chkAtivo);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Controls.Add(dgvUsuarios);
            KeyPreview = true;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btnInserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkAtivo;
        private TextBox txtConfSenha;
        private Label label6;
        private ComboBox cmbNivel;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtBusca;
        private Button btnCancelar;
    }
}