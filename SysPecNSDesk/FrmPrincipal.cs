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
            var msg = MessageBox.Show("Deseja sair?", "Confirmação de saida", MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2,MessageBoxOptions.ServiceNotification);
            if (msg == DialogResult.Yes) Application.Exit();



        }
    }
}
