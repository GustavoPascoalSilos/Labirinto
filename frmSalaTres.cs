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
    public partial class frmSalaTres : Form
    {
        public frmSalaTres()
        {
            InitializeComponent();
        }

        private void btnEsquerda3_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();


            frmPortal.Show();
        }

        private void btnBaixo3_Click(object sender, EventArgs e)
        {
            frmSaidaFalsa frmSaidaFalsa = new frmSaidaFalsa();

            this.Hide();

            frmSaidaFalsa.Closed += (object s, EventArgs ev) => this.Show();

            frmSaidaFalsa.Show();
        }
    }
}
