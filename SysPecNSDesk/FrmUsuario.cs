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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // carregando o combobox de niveis
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

            CarregaGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuario {usuario.Nome}, " +
                    $"foi inserido com sucesso , com o ID {usuario.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfSenha.Clear();
                txtNome.Focus();

                FrmUsuario_Load(sender, e);// não sei o que é
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }
        private void CarregaGrid(string nome = "")
        {
            //preenchendo o data greed com os usuarios

            var lista = Usuario.ObterLista(nome);
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)// para cada usuario na lista
            {
                dgvUsuarios.Rows.Add();//linhas do datagrid usuarios adiciona
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 1 vale usuario nome
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 3 vale nome de objeto nivel com a variavel usuario
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;//linhas do datagrid usuarios com linha varivael cont e coluna 4 vale ativo de objeto usuario 
                cont++;//{cont esta em loop para listar os usuarios}
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show
                    ("Deseja continuar o cadastro?",
                    "Confirmação de saida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);

                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                this.Close();
            }





        }
        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty
                || txtEmail.Text != string.Empty
                || txtSenha.Text != string.Empty
                || txtConfSenha.Text != string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int PosicaoLinha = dgvUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvUsuarios.Rows[PosicaoLinha].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }
    }
}
