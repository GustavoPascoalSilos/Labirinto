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
    public partial class frmSalaUm : Form
    {

        public frmSalaUm()
        {
            InitializeComponent();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            //Cria o novo formulario
            frmSalaDois frmSalaDois = new frmSalaDois();

            //Esconde a tela atual
            this.Hide();

            frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();

            //Mostra a tela SalaDois
            frmSalaDois.Show();
        }



        private void btnCima_Click(object sender, EventArgs e)
        {
            //Cria o novo formulario
            frmPortal frmPortal = new frmPortal();

            //Esconde a tela atual
            this.Hide();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();

            //Mostra a tela SalaDois
            frmPortal.Show();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();

            this.Hide();

            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.Show();
        }


    }
}
