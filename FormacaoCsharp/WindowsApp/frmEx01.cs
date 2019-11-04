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
    public partial class frmEx01 : Form
    {
        public frmEx01()
        {
            InitializeComponent();
        }

        private void btnCalculaMedia_Click(object sender, EventArgs e)
        {
            int idadeRondinele = 27;
            int idadeGabriela = 26;
            int idadeBeatriz = 4;

            double mediaIdade = (idadeRondinele + idadeGabriela + idadeBeatriz) / 3;

            MessageBox.Show("A media de idade e : " + mediaIdade);
        }

        private void btnPIQuebrado_Click(object sender, EventArgs e)
        {
            // Forcando conversao 
            int piInt = (int)3.14;

            double piDouble = 3.14;
            int piQuebrado = (int)piDouble;
            MessageBox.Show("piQuebrado = " + piQuebrado);
            MessageBox.Show("piInt = " + piInt);
        }



        /*
        Mensage de errro : nao e possivel converte double pra int de forma implicira
         int pi = 3.14;
        
         */

    

    }
}
