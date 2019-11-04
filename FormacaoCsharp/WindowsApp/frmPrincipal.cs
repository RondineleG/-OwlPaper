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
            bool podeSacar = (saldo >= valorDoSaque);
            bool realmentePodeSacar = (saldo >= valorDoSaque) && (valorDoSaque > 0);
            bool podeSacarOU = (saldo >= valorDoSaque) || (valorDoSaque > 0);

            double valorInvestido = 1000.0;
            for (int i = 1; i < 12; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }

            MessageBox.Show("Valor investido agora é " + valorInvestido);

            if (podeSacarOU)
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

        private void btnEx01_Click(object sender, System.EventArgs e)
        {
            var ex = new frmEx01();
            ex.Show();
        }

        private void btnEx02_Click(object sender, System.EventArgs e)
        {
            var ex = new frmEx02();
            ex.Show();
        }
    }
}
