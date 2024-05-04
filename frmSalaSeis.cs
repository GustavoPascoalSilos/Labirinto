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
    public partial class frmSalaSeis : Form
    {
        public frmSalaSeis()
        {
            InitializeComponent();
        }

        private void btnCima6_Click(object sender, EventArgs e)
        {
            frmSalaUm frmSalaUm = new frmSalaUm();

            this.Hide();


            frmSalaUm.Show();
        }

        private void btnBaixo6_Click(object sender, EventArgs e)
        {
            frmSalaUm frmSalaUm = new frmSalaUm();

            this.Hide();


            frmSalaUm.Show();
        }

        private void btnEsquerda6_Click(object sender, EventArgs e)
        {
            frmSamara frmSamara = new frmSamara();

            this.Hide();

            frmSamara.Closed += (object s, EventArgs ev) => this.Show();

            frmSamara.Show();
        }
    }
}
