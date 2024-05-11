using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmSamara : Form
    {
        SoundPlayer simpleSound;

        public frmSamara()
        {
            InitializeComponent();

            simpleSound = new SoundPlayer(Properties.Resources.grito_horror);
            simpleSound.Load();
        }

        private void frmSamara_Load(object sender, EventArgs e)
        {
            simpleSound.Play();
        }
    }
}
