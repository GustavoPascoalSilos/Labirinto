namespace Labirinto
{
    partial class frmQuestão
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(624, 27);
            label1.TabIndex = 0;
            label1.Text = "ESCOLHA A OPÇÃO CORRETA E AVANÇE PARA OUTRA SALA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 46);
            label2.Name = "label2";
            label2.Size = new Size(586, 27);
            label2.TabIndex = 1;
            label2.Text = "SE ESCOLHER A OPÇÃO ERRADA IRÁ VOLTAR AO INÍCIO";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(56, 287);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 2;
            button1.Text = "Galileu Galilei";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(617, 287);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 3;
            button2.Text = "Amin Khader";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(58, 389);
            button3.Name = "button3";
            button3.Size = new Size(146, 29);
            button3.TabIndex = 4;
            button3.Text = "Albert Einstein";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(617, 389);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 5;
            button4.Text = "Bhaskara Akaria";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(271, 136);
            label3.Name = "label3";
            label3.Size = new Size(290, 26);
            label3.TabIndex = 6;
            label3.Text = "QUEM CRIOU ESSA FORMULA?";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.bhaskara;
            pictureBox1.Location = new Point(269, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 166);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmQuestão
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmQuestão";
            Text = "frmQuestão";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}