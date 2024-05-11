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
    public partial class frmSalaQuatro : Form
    {

        public frmSalaQuatro()
        {
            InitializeComponent();
        }

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();


            frmPortal.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string resposta = "";

            resposta =  Convert.ToString(txtResposta.Text);



            if (resposta != "25")
            {
                MessageBox.Show("Resposta Errada",
                    "Vai precisa de ajuda?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Resposta CORRETA!"
                    + " VOCÊ VENCEU! ",
                    "Temos um Sherlock Holmes aqui!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                Environment.Exit(0);

            }
        }

        private void txtResposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
           
        }
    }
}
