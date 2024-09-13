namespace SysPecNSDesk
{
    partial class FrmProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            txtCdB = new TextBox();
            txtValorUnit = new TextBox();
            txtUdV = new TextBox();
            txtDesc = new TextBox();
            cmbCategoria = new ComboBox();
            txtDesconto = new TextBox();
            nudEstoqueMinimo = new NumericUpDown();
            btnConsulta = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            dgvEstoque = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codbar = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            valorunit = new DataGridViewTextBoxColumn();
            unidadevenda = new DataGridViewTextBoxColumn();
            catnome = new DataGridViewTextBoxColumn();
            estoquemin = new DataGridViewTextBoxColumn();
            classdesconto = new DataGridViewTextBoxColumn();
            datacad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 90);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo de barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 90);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor unitario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 90);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Unidade de Venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 90);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Estoque Minimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 155);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 222);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 222);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 7;
            label8.Text = "Desconto";
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 44);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // txtCdB
            // 
            txtCdB.Location = new Point(95, 108);
            txtCdB.Name = "txtCdB";
            txtCdB.Size = new Size(145, 23);
            txtCdB.TabIndex = 9;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(247, 108);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(128, 23);
            txtValorUnit.TabIndex = 10;
            // 
            // txtUdV
            // 
            txtUdV.Location = new Point(381, 108);
            txtUdV.Name = "txtUdV";
            txtUdV.Size = new Size(126, 23);
            txtUdV.TabIndex = 11;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(95, 173);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(494, 23);
            txtDesc.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Missangas & Confecção de Joias", "Decoração de tecidos", "Tricô & Suprimentos de Crochê", "Suprimentos para impressão", "Estamparia de Suprimentos", "Produtos de Costura", "Artesanato & Hobby Tecido", "Suprimentos para agulhas", "Artes, Ofícios e Costura", "Pintura, Desenho e Suprimentos de Arte", "Suprimentos Artesanais e Materiais", "Suprimentos para embrulho de presente", "Decorações de Festa", "Tintas Automotivas e Suprimentos para Ti", "Equipamentos para Serviços Pesados e Veí", "Pneus Automotivos e Rodas", "Ferramentas Automotivas e Equipamentos", "Peças e Acessórios de Performance Automo", "Cuidados com o carro", "Óleos e Fluidos", "Peças de Reposição Automotivas", "Luzes, Lâmpadas e Indicadores", "Acessórios para interiores automotivos", "Acessórios Automotivos Externos", "Mercadoria para entusiastas automotivos", "Eletrônica Automotiva e Acessórios", "RV Parts &Acessórios", "Motocicleta", "Produtos para Fraldas para Bebês", "Suprimentos de alimentação para bebês", "Gravidez & Produtos para Maternidade", "Cadeirinhas para Carros de Segurança Inf", "Produtos de segurança para bebês", "Produtos para treinamento de toalete", "Produtos para Cuidados com o Bebê", "Equipamento de viagem para bebés", "Atividade do bebê e produtos de entreten", "Presentes de Bebê", "Papelaria para Bebês", "Mobiliário de Creche, Roupa de Cama e De", "Bebê", "Infantil Roupas e Calçados", "Carrinhos de bebê e acessórios", "Beleza e Cuidados Pessoais", "Perfumes e Fragrâncias", "Produtos para cuidados com o cabelo", "Maquiagem", "Produtos de cuidados da pele", "Ferramentas de Beleza e Acessórios", "Produtos para Cuidados com Pé, Mão e Unh", "Produtos de Higiene Pessoal", "Produtos de barbear e depilação", "Servidores de Computador", "Armazenamento de dados", "Monitores de computador", "Computadores & Tablets", "Peças de reposição de comprimidos", "Redes de Computadores", "Componentes do computador", "Acessórios para Tablets", "Acessórios para laptop", "Componentes externos do computador", "Tecnologia vestível", "Televisores e Produtos de Vídeo", "GPS & Navegação", "Fones de ouvido & Earbuds", "Eletrônica de Escritório", "Áudio portátil & Vídeo", "Leitores de eBook e Acessórios", "Celulares e Acessórios", "Acessórios e Suprimentos", "Projetores de vídeo", "Eletrônica veicular", "Câmera & Foto", "Segurança e Equipamentos de Vigilância", "Computadores", "Home Áudio e Produtos de Teatro", "Consoles de videogame e acessórios", "Roupas para Meninos", "Acessórios para Meninos", "Joias para meninos", "Relógios para Meninos", "Sapatos para Meninos", "Roupas Femininas", "Acessórios para Meninas", "Joias Femininas", "Relógios para Meninas", "Sapatos Femininos", "Uniformes Escolares para Meninas", "Bolsas de viagem", "Sacolas de Viagem", "Sacos de Vestuário", "Conjuntos de Bagagem", "Malas", "Acessórios de Viagem", "Guarda-chuvas", "Mochilas", "Bagagem", "Bolsas para laptop", "Vestuário Masculino", "Acessórios Masculinos", "Relógios Masculinos", "Calçados Masculinos", "Vestuário Feminino", "Bolsas Femininas", "Acessórios Femininos", "Relógios Femininos", "Calçados Femininos", "Joias Femininas", "Mobiliário Infantil", "Cartões-presente", "Produtos de higiene bucal", "Produtos Visão", "Produtos de Bem-Estar e Relaxamento", "Produtos para Cuidados com o Bebê e Cria", "Suprimentos Domésticos", "Produtos para cuidados com a saúde", "Dieta & Nutrição Esportiva", "Suprimentos Médicos de Uso Doméstico e E", "Produtos de bem-estar sexual", "Saúde e Domicílio", "Produtos de Nutrição Esportiva", "Papelaria & Suprimentos para Embrulho de", "Produtos para Portas Comerciais", "Produtos de Transmissão de Energia", "Materiais Industriais", "Industrial Hardware", "Produtos Abrasivos e de Acabamento", "Adesivos Industriais, Selantes e Lubrifi", "Produtos para Movimentação de Materiais", "Testar, Medir e Inspecionar", "Energia Industrial & Ferramentas Manuais", "Hidráulica, Pneumática e Hidráulica", "Filtração", "Componentes Eletrônicos", "Laboratório e Produtos Científicos", "Zeladoria e Abastecimento de Saneamento", "Produtos de Segurança e Saúde Ocupaciona", "Ferramentas de Corte", "Fixadores", "Materiais para Educação Científica", "Equipamentos de Food Service e Supriment", "Produtos de Manufatura Aditiva", "Suprimentos médicos profissionais", "Suprimentos Odontológicos Profissionais", "Embalagem e Envio de Suprimentos", "Equipamentos para lojas de varejo e equi", "Industrial e Científica", "Produtos de Banho", "Roupa de cama", "Home decoração Produtos", "Mobiliário", "Material de limpeza doméstica", "Iluminação Doméstica e Ventiladores de T", "Cozinha e Jantar", "Aquecimento, Resfriamento e Qualidade do", "Loja Infantil em Casa", "Armazenamento doméstico & Organização", "Arte de parede", "Aspiradores de pó e cuidados com o piso", "Produtos de Engomadoria", "Suprimentos para Festas", "Suprimentos para pássaros de estimação", "Suprimentos Cat", "Suprimentos para cães", "Peixes e Animais de Estimação Aquáticos", "Suprimentos para cavalos", "Répteis e suprimentos para anfíbios", "Suprimentos para Pequenos Animais", "Casa Inteligente: Novos Dispositivos Int", "Casa Inteligente: Assistentes de Voz e H", "Casa Inteligente: Fechaduras Inteligente", "Casa Inteligente: Entretenimento Domésti", "Casa Inteligente: Wi-Fi e Rede", "Casa Inteligente: Câmeras e Sistemas de ", "Casa Inteligente: Iluminação", "Casa Inteligente: Plugues e Tomadas", "Casa Inteligente: Aspiradores e Mops", "Termostatos domésticos inteligentes - Ve", "Casa Inteligente: Gramado e Jardim", "Casa Inteligente: Outras Soluções", "Casa Inteligente - Aquecimento e Refrige", "Esportes & Fitness", "Recreação ao ar livre", "Esportes & Ar Livre", "Eletrodomésticos", "Bombas e Equipamentos Hidráulicos", "Pintura, Tratamentos de Parede e Suprime", "Segurança & Segurança", "Lâmpadas", "Ferramentas Elétricas & Ferramentas Manu", "Utensílios de cozinha e banho", "Iluminação & Ventiladores de Teto", "Equipamentos Elétricos", "Hardware", "Material de Construção", "Medição & Layout", "Solda & Solda", "Ferramentas", "Suprimentos para festas infantis", "Figuras de Brinquedo e Conjuntos de jogo", "Novidade Brinquedos & Diversões", "Suprimentos de Artes e Artesanato", "Brinquedos de construção", "Bonecas e Acessórios", "Eletrônica Infantil", "Jogos & Acessórios", "Brinquedos de Aprendizagem e Educação", "Fantoches e Teatros de Marionetas", "Enigmas", "Esportes e Brinquedos ao Ar Livre", "bichos de pelúcia e brinquedos de pelúci", "Brinquedos para bebês e crianças", "Triciclos, Scooters e Vagões", "Brinquedos de dedo", "Conjuntos de jogos de veículos de brinqu", "Brincadeiras Infantis Trens e Bondes", "Brincadeiras Infantis Caminhões", "Carros de Brincar com Crianças e Carros ", "Barcos de Brincadeiras Infantis", "Ônibus para crianças", "Tratores Infantis", "Carros Caça-Níqueis, Pistas de Corrida e", "Sony PSP Jogos, Consoles e Acessórios", "Nintendo DS Jogos, Consoles e Acessórios", "Jogos PlayStation 3, Consoles e Acessóri", "Jogos Wii, Consoles e Acessórios", "Jogos Xbox 360, Consoles e Acessórios", "Jogos para Mac & Acessórios", "Nintendo 3DS & 2DS Consoles, Jogos e Ace", "Sistemas Legados", "Jogos PlayStation Vita, Consolas e Acess", "Jogos Wii U, Consoles e Acessórios", "Jogos PlayStation 4, Consoles e Acessóri", "Jogos Xbox One, Consoles e Acessórios", "Jogos eletrônicos", "Serviços de Jogos de Vídeo Online", "Hardware de Realidade Virtual e Acessóri", "Nintendo Switch Consoles, Jogos e Acessó", "Consolas, Jogos e Acessórios PlayStation", "Xbox Series X & S Consoles, Jogos e Aces", "Jogos para PC & Acessórios", "Roupas para Meninas e Sapatos", "Uniformes Escolares para Meninos" });
            cmbCategoria.Location = new Point(95, 240);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(306, 23);
            cmbCategoria.TabIndex = 16;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(412, 240);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(128, 23);
            txtDesconto.TabIndex = 17;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Location = new Point(519, 109);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(36, 23);
            nudEstoqueMinimo.TabIndex = 21;
            nudEstoqueMinimo.ValueChanged += nudEstoqueMinimo_ValueChanged;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(471, 290);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(117, 23);
            btnConsulta.TabIndex = 20;
            btnConsulta.Text = "&Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(283, 290);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(95, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "&Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { id, codbar, descricao, valorunit, unidadevenda, catnome, estoquemin, classdesconto, datacad });
            dgvEstoque.Location = new Point(75, 358);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(538, 150);
            dgvEstoque.TabIndex = 22;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick_1;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // codbar
            // 
            codbar.HeaderText = "Codigo de Barras";
            codbar.Name = "codbar";
            codbar.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descricao";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // valorunit
            // 
            valorunit.HeaderText = "Valor Unitario";
            valorunit.Name = "valorunit";
            valorunit.ReadOnly = true;
            // 
            // unidadevenda
            // 
            unidadevenda.HeaderText = "Unidade de Venda";
            unidadevenda.Name = "unidadevenda";
            unidadevenda.ReadOnly = true;
            // 
            // catnome
            // 
            catnome.HeaderText = "Categoria";
            catnome.Name = "catnome";
            catnome.ReadOnly = true;
            // 
            // estoquemin
            // 
            estoquemin.HeaderText = "Estoque Minimo";
            estoquemin.Name = "estoquemin";
            estoquemin.ReadOnly = true;
            // 
            // classdesconto
            // 
            classdesconto.HeaderText = "Desconto";
            classdesconto.Name = "classdesconto";
            classdesconto.ReadOnly = true;
            // 
            // datacad
            // 
            datacad.HeaderText = "Data de Cadastro";
            datacad.Name = "datacad";
            datacad.ReadOnly = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 544);
            Controls.Add(dgvEstoque);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(btnConsulta);
            Controls.Add(btnEditar);
            Controls.Add(txtID);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtDesconto);
            Controls.Add(label2);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(txtUdV);
            Controls.Add(label5);
            Controls.Add(txtValorUnit);
            Controls.Add(label6);
            Controls.Add(txtCdB);
            Controls.Add(label7);
            Controls.Add(label8);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private TextBox txtCdB;
        private TextBox txtValorUnit;
        private TextBox txtUdV;
        private TextBox txtDesc;
        private ComboBox cmbCategoria;
        private TextBox txtDesconto;
        private Button btnConsulta;
        private Button btnEditar;
        private Button btnAdd;
        private NumericUpDown nudEstoqueMinimo;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn codbar;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn valorunit;
        private DataGridViewTextBoxColumn unidadevenda;
        private DataGridViewTextBoxColumn catnome;
        private DataGridViewTextBoxColumn estoquemin;
        private DataGridViewTextBoxColumn classdesconto;
        private DataGridViewTextBoxColumn datacad;
    }
}