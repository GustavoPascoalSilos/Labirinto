using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmSalaCinco : Form
    {
        Random NumeroAleatorio = new Random();
        public frmSalaCinco()
        {
            InitializeComponent();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            int posiçaox = NumeroAleatorio.Next(1, 1000);
            int posicaoy = NumeroAleatorio.Next(1, 500);
            btnEsquerda5.Location = new Point(posiçaox, posicaoy);
        }

        private void btnBaixo_MouseEnter(object sender, EventArgs e)
        {

            int posiçaox = NumeroAleatorio.Next(1, 1000);
            int posicaoy = NumeroAleatorio.Next(1, 300);
            btnBaixo5.Location = new Point(posiçaox, posicaoy);
        }



        private void btnCima5_MouseEnter(object sender, EventArgs e)
        {

            int posiçaox = NumeroAleatorio.Next(1, 1000);
            int posicaoy = NumeroAleatorio.Next(1, 300);
            btnCima5.Location = new Point(posiçaox, posicaoy);
        }

        private void btnDireita5_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();

            frmPortal.Show();
        }

        private void btnSeta_Click(object sender, EventArgs e)
        {
            frmSalaQuatro frmSalaQuatro = new frmSalaQuatro();

            this.Hide();

            frmSalaQuatro.Show();

            frmSalaQuatro.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
