using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class frmEx02 : Form
    {
        public frmEx02()
        {
            InitializeComponent();
        }

        private void btnOperadorLogico_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10;

            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;

                MessageBox.Show("Salque realizado");
            }
            else
            {
                MessageBox.Show("Sem Saldo");
            }

        }
    }
}
