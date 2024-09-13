using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysPecNSLib;

namespace SysPecNSDesk
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCdB.Text,
                txtDesc.Text,
                double.Parse(txtValorUnit.Text),
                txtUdV.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)nudEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");

                FrmProduto_Load_1(sender, e);
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (btnConsulta.Text == "&Consultar")
            {
                LimpaControles();
                nudEstoqueMinimo.Value = 0;
                btnConsulta.Text = "&Obter por ID";
                txtID.Focus();
                txtID.ReadOnly = false;
            }
            else
            {
                if (txtID.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtID.Text));
                    txtCdB.Text = produto.CodBar;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDesc.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUdV.Text = produto.UnidadeVenda;
                    //nudEstoqueMinimo.Value = produto.EstoqueMinimo;
                    cmbCategoria.SelectedIndex =
                        cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }

        }

        private void FrmProduto_Load_1(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            var lista = Produto.ObterLista();
            dgvEstoque.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[count].Cells[0].Value = produto.Id;
                dgvEstoque.Rows[count].Cells[1].Value = produto.CodBar;
                dgvEstoque.Rows[count].Cells[2].Value = produto.Descricao;
                dgvEstoque.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvEstoque.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvEstoque.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvEstoque.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvEstoque.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvEstoque.Rows[count].Cells[8].Value = produto.DataCad;
                count++;
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpaControles()
        {
            txtCdB.Clear();
            txtValorUnit.Clear();
            txtUdV.Clear();
            txtDesc.Clear();
            txtDesconto.Clear();

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtID.Text),
                txtCdB.Text,
                txtDesc.Text,
                double.Parse(txtValorUnit.Text),
                txtUdV.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)nudEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text)
                );
            produto.Atualizar();
            MessageBox.Show($"Produto {produto.Id} - {produto.Descricao} atualizado com sucesso");
            btnEditar.Enabled = false;
            txtID.ReadOnly = true;
            btnConsulta.Text = "&Consultar";
            LimpaControles();
            FrmProduto_Load_1(sender, e);


        }

        private void dgvEstoque_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudEstoqueMinimo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
