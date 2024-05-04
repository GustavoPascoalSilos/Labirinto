namespace Labirinto
{
    partial class frmSaidaFalsa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnSairFalso = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saida;
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSairFalso
            // 
            btnSairFalso.BackColor = Color.Coral;
            btnSairFalso.Location = new Point(674, -2);
            btnSairFalso.Name = "btnSairFalso";
            btnSairFalso.Size = new Size(130, 453);
            btnSairFalso.TabIndex = 1;
            btnSairFalso.Text = "SAIR KK";
            btnSairFalso.UseVisualStyleBackColor = false;
            btnSairFalso.Click += btnSairFalso_Click;
            // 
            // frmSaidaFalsa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSairFalso);
            Controls.Add(pictureBox1);
            Name = "frmSaidaFalsa";
            Text = "frmSaidaFalsa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSairFalso;
    }
}