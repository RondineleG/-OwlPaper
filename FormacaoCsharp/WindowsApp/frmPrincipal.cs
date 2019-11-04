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
            double saldo = 10.0;
            double valorDoSaque = 90.0;
            saldo -= valorDoSaque;

            if (saldo >= valorDoSaque)
            {
                saldo = saldo - valorDoSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

        }
   
       public void MetodoAleatorioa()
        {
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
