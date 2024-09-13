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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

            //frmUsuario.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja sair?", "Confirmação de saida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            if (msg == DialogResult.Yes) Application.Exit();



        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new();
            frmFornecedor.MdiParent = this;
            frmFornecedor.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.ShowDialog();
            Text += $"({Program.UsuarioLogado.Email})";
            toolStripStatusLabel1.Text = $" {Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo = new();
            frmPedidoNovo.MdiParent = this;
            frmPedidoNovo.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstoque frmEstoque = new();
            frmEstoque.MdiParent = this;
            frmEstoque.Show();
        }
    }
}
