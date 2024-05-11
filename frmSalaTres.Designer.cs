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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCima3
            // 
            btnCima3.BackColor = Color.Red;
            btnCima3.FlatAppearance.BorderSize = 0;
            btnCima3.FlatStyle = FlatStyle.Flat;
            btnCima3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima3.Location = new Point(345, 12);
            btnCima3.Name = "btnCima3";
            btnCima3.Size = new Size(73, 43);
            btnCima3.TabIndex = 2;
            btnCima3.Text = "↑";
            btnCima3.UseVisualStyleBackColor = false;
            btnCima3.Click += btnCima3_Click;
            // 
            // btnEsquerda3
            // 
            btnEsquerda3.FlatAppearance.BorderSize = 0;
            btnEsquerda3.FlatStyle = FlatStyle.Flat;
            btnEsquerda3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnDireita3.FlatAppearance.BorderSize = 0;
            btnDireita3.FlatStyle = FlatStyle.Flat;
            btnDireita3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita3.Location = new Point(715, 192);
            btnDireita3.Name = "btnDireita3";
            btnDireita3.Size = new Size(73, 43);
            btnDireita3.TabIndex = 4;
            btnDireita3.Text = "→";
            btnDireita3.UseVisualStyleBackColor = true;
            btnDireita3.Click += btnDireita3_Click;
            // 
            // btnBaixo3
            // 
            btnBaixo3.FlatAppearance.BorderSize = 0;
            btnBaixo3.FlatStyle = FlatStyle.Flat;
            btnBaixo3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo3.Location = new Point(345, 395);
            btnBaixo3.Name = "btnBaixo3";
            btnBaixo3.Size = new Size(73, 43);
            btnBaixo3.TabIndex = 5;
            btnBaixo3.Text = "↓";
            btnBaixo3.UseVisualStyleBackColor = true;
            btnBaixo3.Click += btnBaixo3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 188);
            label1.Name = "label1";
            label1.Size = new Size(121, 43);
            label1.TabIndex = 6;
            label1.Text = "SALA 3";
            // 
            // frmSalaTres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBaixo3);
            Controls.Add(btnDireita3);
            Controls.Add(btnEsquerda3);
            Controls.Add(btnCima3);
            Name = "frmSalaTres";
            Text = "frmSalaTres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCima3;
        private Button btnEsquerda3;
        private Button btnDireita3;
        private Button btnBaixo3;
        private Label label1;
    }
}