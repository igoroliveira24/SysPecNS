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
    public partial class FrmDgvClientesParaPedido : Form
    {
        public FrmDgvClientesParaPedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            Program.frmDgvClienteParaPedido.Id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value);
            Program.frmDgvClienteParaPedido.Nome = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[1].Value);
            Program.frmDgvClienteParaPedido.CPF = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[2].Value);            
            Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDgvClientesParaPedido_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dataGridView1.Rows.Clear();
            int cont = 0;

            var list2 = Endereco.ObterListaPorClientesPorId(nome);

            foreach (var cliente in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = cliente.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dataGridView1.Rows[cont].Cells[1].Value = cliente.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email
                dataGridView1.Rows[cont].Cells[2].Value = cliente.CPF;//linhas do datagrid usuarios com linha varivael cont e coluna 3 vale nome de objeto nivel com a variavel usuario
                dataGridView1.Rows[cont].Cells[3].Value = cliente.Telefone;//linhas do datagrid usuarios com linha varivael cont e coluna 4 vale ativo de objeto usuario 
                dataGridView1.Rows[cont].Cells[4].Value = cliente.Email;
                dataGridView1.Rows[cont].Cells[5].Value = cliente.Data_nasc;
                dataGridView1.Rows[cont].Cells[6].Value = cliente.Data_cad;
                dataGridView1.Rows[cont].Cells[7].Value = cliente.Ativo;

                cont++;//{cont esta em loop para listar os usuarios}
            }


        }
    }
}
