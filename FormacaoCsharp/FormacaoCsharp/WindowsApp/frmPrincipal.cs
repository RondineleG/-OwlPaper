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
            // Tipo que recebe numeros inteiroa
           
            int numeroDaConta = 1;

            // Tipo que recebe numeros reais
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            saldo -= valorDoSaque;

            int valor = 1;
            long valorGrande = valor;

            //short valorPequeno = valor;

            short valorPequeno = (short)valor;

            // Tipo que recebe numeros conjunto de caracter
            string mensagem = "Minha Mensagem";
            MessageBox.Show(mensagem);
            /*
             
             Bloco de comentario
             
             */
            string mensagem2 = "Olá ";
            string nome = "Rondinele";

            MessageBox.Show(mensagem2 + nome);

            int idade = 25;
            string mensagem3 = "sua idade é: " + idade;

            MessageBox.Show(mensagem3);
        }
    }
}
