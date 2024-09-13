using SysPecNSLib;

namespace SysPecNSDesk;





public partial class FrmPedidoNovo : Form
{


    Produto produto;
    ItemPedido itempedido;

    public FrmPedidoNovo()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void FrmPedidoNovo_Load(object sender, EventArgs e)
    {
        txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
    }

    private void btnInserePedido_Click(object sender, EventArgs e)
    {
        Pedido pedido = new(
            Program.UsuarioLogado,
            Cliente.ObterporId(int.Parse(txtIdCliente.Text)),
            0
            );
        pedido.Inserir();
        txtIdPedido.Text = pedido.Id.ToString();
        grbItens.Enabled = true;
        grbIdentificacao.Enabled = false;
        txtCodBar.Focus();
    }

    private void label10_Click(object sender, EventArgs e)
    {

    }

    private void txtIdCliente_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtCodBar_Leave(object sender, EventArgs e)
    {
        if (txtCodBar.TextLength > 0)
        {
            produto = Produto.ObterPorId(txtCodBar.Text);
            txtDescricaoItem.Text = produto.Descricao;
            if (produto.ClasseDesconto == 0)
            {
                txtDescontoItens.Enabled = false;
            }
            else
            {
                txtDescontoItens.Enabled = true;
                label15.Text = $"{produto.ValorUnit * produto.ClasseDesconto}";
            }
            txtValorUnitItem.Text = produto.ValorUnit.ToString();
            txtValorUnitItem.ReadOnly = true;
            txtQuantidadeItem.Focus();
        }
    }



    private void btnAddItem_Click(object sender, EventArgs e)
    {


       
       Estoque estoque = new();

        estoque = Estoque.ObterQuantidadePorProdutoId(produto.Id);
            

                if (int.Parse(txtQuantidadeItem.Text) <= estoque.Quantidade)
                {         
                    ItemPedido item = new(
                    int.Parse(txtIdPedido.Text),
                    produto,
                    produto.ValorUnit,
                    double.Parse(txtQuantidadeItem.Text),
                    double.Parse(txtDescontoItens.Text)
                    );
                    if (double.Parse(label15.Text) > double.Parse(txtDescontoItens.Text))
                    {


                        item.Inserir();

                        produto = new();
                        txtDescontoItens.Text = "0";
                        txtDescricaoItem.Clear();
                        txtValorUnitItem.Text = "0";
                        txtQuantidadeItem.Text = "1";
                        txtCodBar.Clear();
                        txtCodBar.Focus();
                        txtDescontodoPedido.Enabled = true;

                        PreencherGridItems();
                    }
                    else
                    {
                        MessageBox.Show("O Valor de Desconto é Maior do que o permitido");
                        txtDescontoItens.Text = Convert.ToString(0.00);
                    }
                }
                else
                {
                    MessageBox.Show("A Quantidade excede o numero de estoque");
                    txtQuantidadeItem.Clear();
                }
            
            
        
        





    }

    private void PreencherGridItems()
    {
        var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
        dgvItensPedido.Rows.Clear();
        int linha = 0;
        double desconto = 0;
        double total = 0;
        double subtotal = 0;
        foreach (var item in itens)
        {
            dgvItensPedido.Rows.Add();
            dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
            dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
            dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
            dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
            dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade.ToString("#0.000");
            dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("#0.00");
            dgvItensPedido.Rows[linha].Cells[6].Value = item.ValorUnit * item.Quantidade - item.Desconto;
            linha++;
            total += item.ValorUnit * item.Quantidade - item.Desconto;
            desconto += item.Desconto;
            subtotal += item.ValorUnit * item.Quantidade;



        }
        txtTotal.Text = total.ToString("#0.00");
        textBox2.Text = desconto.ToString("#0.00");
        txtSubTotal.Text = subtotal.ToString("#0.00");


    }

    private void button2_Click(object sender, EventArgs e)
    {
        FrmDgvClientesParaPedido frmDgvClientesParaPedido = new();
        frmDgvClientesParaPedido.ShowDialog();
        txtIdCliente.Text = $" {Program.frmDgvClienteParaPedido.Id}";
        txtCpfCliente.Text = $" {Program.frmDgvClienteParaPedido.CPF}";
        txtNomeClientes.Text = $" {Program.frmDgvClienteParaPedido.Nome}";





    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        double total = double.Parse(txtSubTotal.Text) - double.Parse(textBox2.Text) - double.Parse(txtDescontodoPedido.Text);
        textBox4.Text = total.ToString("#0.00");
        if (double.Parse(txtTotal.Text) > double.Parse(txtDescontodoPedido.Text) || (double.Parse(txtTotal.Text) == double.Parse(txtDescontodoPedido.Text)))
        {
            if (txtTotal.Text == textBox4.Text)
            {
                Pedido pedido = new(
                    int.Parse(txtIdPedido.Text),
                    "F"
                );

                pedido.AlterarStatus();

                Close();
            }
            else
            {
                txtTotal.Text = textBox4.Text;

            }
        }
        else
        {
            MessageBox.Show("O valor do desconto é maior que o preço do pedido");
            txtDescontodoPedido.Text = Convert.ToString(0);
        }
    }

    private void FrmPedidoNovo_Enter(object sender, EventArgs e)
    {

    }

    private void txtQuantidadeItem_TextChanged(object sender, EventArgs e)
    {
        if (txtQuantidadeItem.Text == string.Empty)
        {
            txtQuantidadeItem.Text = Convert.ToString(1);
        }
        else
        {
            double desconto = 0;
            desconto = double.Parse($"{produto.ValorUnit * double.Parse(txtQuantidadeItem.Text) * produto.ClasseDesconto}");
            label15.Text = desconto.ToString("#0.00");


        }

    }

    private void txtDescontodoPedido_TextChanged(object sender, EventArgs e)
    {
        if (txtDescontodoPedido.Text == string.Empty)
        {
            txtDescontodoPedido.Text = Convert.ToString(0);
        }
        else
        {
            double desconto = 0;
            desconto = double.Parse($"{double.Parse(txtSubTotal.Text) - double.Parse(textBox2.Text) - double.Parse(txtDescontodoPedido.Text)}");
            textBox4.Text = desconto.ToString("#0.00");


        }
    }

    private void btnCancelaPedido_Click(object sender, EventArgs e)
    {
        var msg = MessageBox.Show("Deseja realmente cancelar o pedido", "Tem certeza?", MessageBoxButtons.YesNo);
        if (msg == DialogResult.Yes)
        {
            Pedido pedido = new(
            int.Parse(txtIdPedido.Text),
            "C"
            );
            pedido.AlterarStatus();
            Close();
        }






    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
             

        
    }
}


