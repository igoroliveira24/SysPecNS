﻿using MySqlX.XDevAPI;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            // carregando o combobox de niveis
            CarregaGrid();
            CarregaGrid2();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtEmail.Text,
                txtCPF.Text,
                txtTelefone.Text,
                dtmDataNasc.Value);





            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Cliente {cliente.Nome}, " +
                    $"foi inserido com sucesso , com o ID {cliente.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                txtNome.Focus();

                FrmClientes_Load(sender, e);// não sei o que é
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                CarregaGrid(textBox6.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista (nome);
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

            foreach (var endereco in list2)
            {
                dataGridView1.Rows[cont].Cells[8].Value = endereco.Logradouro + ", " + endereco.Numero + ", " + endereco.Bairro + ", " + endereco.Cidade + ", " + endereco.UF;
                cont++;//{cont esta em loop para listar os usuarios}
            }
        }

        private void CarregaGrid2(string nome = "")
        {
            var lista = Endereco.ObterLista (nome);
            dgvEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)// para cada usuario na lista
            {
                dgvEndereco.Rows.Add();//linhas do datagrid usuarios adiciona
                dgvEndereco.Rows[cont].Cells[0].Value = endereco.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dgvEndereco.Rows[cont].Cells[1].Value = endereco.Cliente_id.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email
                dgvEndereco.Rows[cont].Cells[2].Value = endereco.Cep;//linhas do datagrid usuarios com linha varivael cont e coluna 3 vale nome de objeto nivel com a variavel usuario
                dgvEndereco.Rows[cont].Cells[3].Value = endereco.Logradouro;//linhas do datagrid usuarios com linha varivael cont e coluna 4 vale ativo de objeto usuario 
                dgvEndereco.Rows[cont].Cells[4].Value = endereco.Numero;
                dgvEndereco.Rows[cont].Cells[5].Value = endereco.Complemento;
                dgvEndereco.Rows[cont].Cells[6].Value = endereco.Bairro;
                dgvEndereco.Rows[cont].Cells[7].Value = endereco.Cidade;
                dgvEndereco.Rows[cont].Cells[8].Value = endereco.UF;
                dgvEndereco.Rows[cont].Cells[9].Value = endereco.Tipo;
                cont++;//{cont esta em loop para listar os usuarios}
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void brnInserir_Endereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                Cliente.ObterporId(Convert.ToInt32(txtidCliente_Endereco.Text)),
                txtCEP_Endereco.Text,
                txtLogradou_Endereco.Text,
                txtNumero_Endereco.Text,
                txtComplemento_Endereco.Text,
                txtBairro_Endereco.Text,
                txtCidade_Endereco.Text,
                txtUF_Endereco.Text,
                txtTipo_Endereco.Text
                );


            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco.Id.ToString();
                txtidCliente_Endereco.Text = endereco.Cliente_id.ToString();
                MessageBox.Show($"O Endereco {endereco.Cliente_id}, " +
                    $"foi inserido com sucesso , com o ID {endereco.Id}");
                txtId_Endereco.Clear();
                txtidCliente_Endereco.Clear();
                txtLogradou_Endereco.Clear();
                txtNumero_Endereco.Clear();
                txtComplemento_Endereco.Clear();
                txtBairro_Endereco.Clear();
                txtCidade_Endereco.Clear();
                txtUF_Endereco.Clear();
                txtTipo_Endereco.Clear();
                txtNome.Focus();

                FrmClientes_Load(sender, e);// não sei o que é
            }
            else
            {
                MessageBox.Show("Falha ao gravar");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
