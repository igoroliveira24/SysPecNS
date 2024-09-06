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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text !=string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                
               
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuario está inativo. \nProcure a gerência.");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalidos ou inexistentes. \nProcure a gerência");
                    txtEmail.Focus();
                }
                                  
            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha.");
                txtEmail.Focus();
            }
        }
    }
}
