using SysPecNSLib;
using System.Diagnostics.CodeAnalysis;
namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("OLÁ");
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string operacao = cmbOperacao.Text;
            double posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (txtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(txtNumero1.Text);
            }

            double numero2 = 0;
            double a = 0;
            

            
                if (txtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(txtNumero2.Text);
                   
                    a = numero2;

                }

            

            
            
           

            double resultado = 0;
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;
                case 1:
                    resultado = numero1 / numero2;
                    break;
                case 2:
                    resultado = numero1 + numero2;
                    break;
                case 3:
                    resultado = numero1 - numero2;
                    break;
                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;
                case 5:
                    resultado = Math.Pow(numero1,1/numero2);
                    break;
                case 6:
                    resultado = Math.Log(numero1,a);
                    break;
                default:
                    break;



            }



            //if (posicaoOperacao == 0)
            //{
            //    resultado = numero1 * numero2;

            //}

            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado}");

            //for (int i = 0; i < 10; i++)
            //{
            //    lstResultado.Items.Add($"{numero} x {i + 1} = {numero * (i + 1)}");
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text.Length != 0 && cmbOperacao.SelectedIndex >= 0 && txtNumero1.Text.Length != 0)
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }

                    
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length != 0 && cmbOperacao.SelectedIndex >= 0 && txtNumero2.Text.Length != 0)
            {
                btnConfirmar.Enabled = true;
            }         
            else
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           /* if (cmbOperacao.SelectedIndex !=5)
            {
                txtNumero2.Enabled = true;
            }
            else
            {
                txtNumero2.Enabled = false;
                
            }*/
            txtNumero1.Clear(); 
            txtNumero2.Clear();
            txtNumero1.Focus();
            btnConfirmar.Enabled = false;
        }
    }
}
