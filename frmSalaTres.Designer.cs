namespace Labirinto
{
    partial class frmSalaTres
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
            btnCima3 = new Button();
            btnEsquerda3 = new Button();
            btnDireita3 = new Button();
            btnBaixo3 = new Button();
            SuspendLayout();
            // 
            // btnCima3
            // 
            btnCima3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima3.Location = new Point(345, 12);
            btnCima3.Name = "btnCima3";
            btnCima3.Size = new Size(73, 43);
            btnCima3.TabIndex = 2;
            btnCima3.Text = "↑";
            btnCima3.UseVisualStyleBackColor = true;
            // 
            // btnEsquerda3
            // 
            btnEsquerda3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsquerda3.Location = new Point(12, 192);
            btnEsquerda3.Name = "btnEsquerda3";
            btnEsquerda3.Size = new Size(73, 43);
            btnEsquerda3.TabIndex = 3;
            btnEsquerda3.Text = "←";
            btnEsquerda3.UseVisualStyleBackColor = true;
            btnEsquerda3.Click += btnEsquerda3_Click;
            // 
            // btnDireita3
            // 
            btnDireita3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita3.Location = new Point(715, 192);
            btnDireita3.Name = "btnDireita3";
            btnDireita3.Size = new Size(73, 43);
            btnDireita3.TabIndex = 4;
            btnDireita3.Text = "→";
            btnDireita3.UseVisualStyleBackColor = true;
            // 
            // btnBaixo3
            // 
            btnBaixo3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo3.Location = new Point(345, 395);
            btnBaixo3.Name = "btnBaixo3";
            btnBaixo3.Size = new Size(73, 43);
            btnBaixo3.TabIndex = 5;
            btnBaixo3.Text = "↓";
            btnBaixo3.UseVisualStyleBackColor = true;
            btnBaixo3.Click += btnBaixo3_Click;
            // 
            // frmSalaTres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBaixo3);
            Controls.Add(btnDireita3);
            Controls.Add(btnEsquerda3);
            Controls.Add(btnCima3);
            Name = "frmSalaTres";
            Text = "frmSalaTres";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCima3;
        private Button btnEsquerda3;
        private Button btnDireita3;
        private Button btnBaixo3;
    }
}