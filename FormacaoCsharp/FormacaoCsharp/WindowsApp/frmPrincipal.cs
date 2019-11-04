using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void brtClick_Click(object sender, System.EventArgs e)
        {
            int numeroDaConta = 1;
           
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            saldo -= valorDoSaque;

            MessageBox.Show("O saldo da conta após o saque é: " + saldo);
        }
    }
}
