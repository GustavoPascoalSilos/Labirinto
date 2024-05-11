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
    public partial class frmQuestão : Form
    {
        public frmQuestão()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSalaCinco frmSalaCinco = new frmSalaCinco();

            this.Hide();

            frmSalaCinco.Show();

            frmSalaCinco.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Show();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Show();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Show();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();
        }

       
    }
}



