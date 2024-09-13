using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            nudQuantidade.Maximum = 10000;
        }

        private void CarregaGrid()
        {
            var lista = Estoque.ObterListaPorProdutoIdEstoque();
            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var estoque in lista)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[cont].Cells[0].Value = estoque.ProdutoId.Id;
                dataGridView1.Rows[cont].Cells[1].Value = estoque.ProdutoId.Descricao;
                dataGridView1.Rows[cont].Cells[2].Value = estoque.Quantidade;
                dataGridView1.Rows[cont].Cells[3].Value = estoque.DataUltMov;

                cont++;//{cont esta em loop para listar os usuarios}
            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            txtProdutoId.Text = dataGridView1.Rows[PosicaoLinha].Cells[0].Value.ToString();
            txtDescricao.Text = dataGridView1.Rows[PosicaoLinha].Cells[1].Value.ToString();
            txtQuantidade.Text = dataGridView1.Rows[PosicaoLinha].Cells[2].Value.ToString();
            btnAltera.Enabled = true;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            
            Estoque estoque = new(
            Produto.ObterPorId(int.Parse(txtProdutoId.Text)),
            Convert.ToInt32(nudQuantidade.Value)
            );
            if ((double)nudQuantidade.Value > estoque.ProdutoId.EstoqueMinimo)
            {
                estoque.AlterarEstoque();
                FrmEstoque_Load(sender, e);

                txtProdutoId.Clear();
                txtDescricao.Clear();
                txtQuantidade.Clear();
                nudQuantidade.Value = 0;
            }
            else
            {
                MessageBox.Show("A Quantidade minima foi atingida, deve ser colocado um numero de estoque maior");
            }






        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelaAlteracao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
