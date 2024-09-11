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

        ItemPedido item = new(
            int.Parse(txtIdPedido.Text),
            produto,
            produto.ValorUnit,
            double.Parse(txtQuantidadeItem.Text),
            double.Parse(txtDescontoItens.Text)
            );
        item.Inserir();

        produto = new();
        txtDescontoItens.Text = "0";
        txtDescricaoItem.Clear();
        txtValorUnitItem.Text = "0";
        txtQuantidadeItem.Text = "1";
        txtCodBar.Clear();
        txtCodBar.Focus();



        PreencherGridItems();

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
        if (txtTotal.Text == textBox4.Text)
        {
            this.Close();
        }
        else
        {
            txtTotal.Text = textBox4.Text;
        }
    }

    private void FrmPedidoNovo_Enter(object sender, EventArgs e)
    {

    }

    private void txtQuantidadeItem_TextChanged(object sender, EventArgs e)
    {
        itempedido = ItemPedido.ObterPoId(txtQuantidadeItem.Text);

        label15.Text = $"{produto.ValorUnit * itempedido.Quantidade * produto.ClasseDesconto}";
    }
}


