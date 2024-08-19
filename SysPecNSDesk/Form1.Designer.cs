namespace SysPecNSDesk
{
    partial class Form1
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
            txtNumero1 = new TextBox();
            lstResultado = new ListBox();
            btnConfirmar = new Button();
            cmbOperacao = new ComboBox();
            txtNumero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(153, 144);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(154, 173);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(307, 199);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Enabled = false;
            btnConfirmar.Location = new Point(386, 144);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritmos" });
            cmbOperacao.Location = new Point(154, 89);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 4;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(270, 144);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 5;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 71);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Operação";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 126);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Valor 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 126);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Valor 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero2);
            Controls.Add(cmbOperacao);
            Controls.Add(btnConfirmar);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumero1;
        private ListBox lstResultado;
        private Button btnConfirmar;
        private ComboBox cmbOperacao;
        private TextBox txtNumero2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
