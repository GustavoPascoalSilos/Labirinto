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
    public partial class frmSalaDois : Form
    {
        Random NumeroAleatorio = new Random();
        public frmSalaDois()
        {
            InitializeComponent();
        }

        private void btnEsquerda2_MouseEnter(object sender, EventArgs e)
        {
            int posiçaox = NumeroAleatorio.Next(1, 750);
            int posicaoy = NumeroAleatorio.Next(1, 250);
            btnEsquerda2.Location = new Point(posiçaox, posicaoy);
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está perdido?",
                "Esse botão não faz nada KKKKKK",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            frmSalaTres frmSalaTres = new frmSalaTres();

            this.Hide();

            frmSalaTres.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaTres.Show();
        }
    }
}
