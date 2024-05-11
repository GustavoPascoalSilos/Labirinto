namespace Labirinto
{
    partial class frmSalaDois
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
            btnCima = new Button();
            btnDireita = new Button();
            btnBaixo = new Button();
            btnEsquerda2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCima
            // 
            btnCima.FlatAppearance.BorderSize = 0;
            btnCima.FlatStyle = FlatStyle.Flat;
            btnCima.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima.Location = new Point(355, 12);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(73, 43);
            btnCima.TabIndex = 1;
            btnCima.Text = "↑";
            btnCima.UseVisualStyleBackColor = true;
            btnCima.Click += btnCima_Click;
            // 
            // btnDireita
            // 
            btnDireita.FlatAppearance.BorderSize = 0;
            btnDireita.FlatStyle = FlatStyle.Flat;
            btnDireita.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita.Location = new Point(715, 204);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(73, 43);
            btnDireita.TabIndex = 5;
            btnDireita.Text = "→";
            btnDireita.UseVisualStyleBackColor = true;
            btnDireita.Click += btnDireita_Click;
            // 
            // btnBaixo
            // 
            btnBaixo.FlatAppearance.BorderSize = 0;
            btnBaixo.FlatStyle = FlatStyle.Flat;
            btnBaixo.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo.Location = new Point(355, 385);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(73, 43);
            btnBaixo.TabIndex = 6;
            btnBaixo.Text = "↓";
            btnBaixo.UseVisualStyleBackColor = true;
            btnBaixo.Click += btnBaixo_Click;
            // 
            // btnEsquerda2
            // 
            btnEsquerda2.FlatAppearance.BorderSize = 0;
            btnEsquerda2.FlatStyle = FlatStyle.Flat;
            btnEsquerda2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsquerda2.Location = new Point(12, 204);
            btnEsquerda2.Name = "btnEsquerda2";
            btnEsquerda2.Size = new Size(73, 43);
            btnEsquerda2.TabIndex = 7;
            btnEsquerda2.Text = "←";
            btnEsquerda2.UseVisualStyleBackColor = true;
            btnEsquerda2.MouseEnter += btnEsquerda2_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 188);
            label1.Name = "label1";
            label1.Size = new Size(120, 43);
            label1.TabIndex = 8;
            label1.Text = "SALA 2";
            // 
            // frmSalaDois
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEsquerda2);
            Controls.Add(btnBaixo);
            Controls.Add(btnDireita);
            Controls.Add(btnCima);
            Name = "frmSalaDois";
            Text = "frmSalaDois";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCima;
        private Button btnDireita;
        private Button btnBaixo;
        private Button btnEsquerda2;
        private Label label1;
    }
}