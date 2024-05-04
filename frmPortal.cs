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
    public partial class frmPortal : Form
    {
        public frmPortal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Criando uma instancia para um novo formulário
            frmSalaUm frmSalaum = new frmSalaUm();
            
            this.Hide();

            frmSalaum.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaum.ShowDialog();
        }
    }
}
