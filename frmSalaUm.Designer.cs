namespace Labirinto
{
    partial class frmSalaUm
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
            btnBaixo = new Button();
            btnDireita = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCima
            // 
            btnCima.FlatAppearance.BorderSize = 0;
            btnCima.FlatStyle = FlatStyle.Flat;
            btnCima.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima.ForeColor = SystemColors.ButtonHighlight;
            btnCima.Location = new Point(348, 12);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(73, 43);
            btnCima.TabIndex = 0;
            btnCima.Text = "↑";
            btnCima.UseVisualStyleBackColor = true;
            btnCima.Click += btnCima_Click;
            // 
            // btnBaixo
            // 
            btnBaixo.FlatAppearance.BorderSize = 0;
            btnBaixo.FlatStyle = FlatStyle.Flat;
            btnBaixo.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo.ForeColor = SystemColors.ButtonHighlight;
            btnBaixo.Location = new Point(348, 395);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(73, 43);
            btnBaixo.TabIndex = 3;
            btnBaixo.Text = "↓";
            btnBaixo.UseVisualStyleBackColor = true;
            btnBaixo.Click += btnBaixo_Click;
            // 
            // btnDireita
            // 
            btnDireita.FlatAppearance.BorderSize = 0;
            btnDireita.FlatStyle = FlatStyle.Flat;
            btnDireita.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita.ForeColor = SystemColors.ButtonHighlight;
            btnDireita.Location = new Point(715, 209);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(73, 43);
            btnDireita.TabIndex = 4;
            btnDireita.Text = "→";
            btnDireita.UseVisualStyleBackColor = true;
            btnDireita.Click += btnDireita_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(329, 197);
            label1.Name = "label1";
            label1.Size = new Size(118, 43);
            label1.TabIndex = 5;
            label1.Text = "SALA 1";
            // 
            // frmSalaUm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDireita);
            Controls.Add(btnBaixo);
            Controls.Add(btnCima);
            Name = "frmSalaUm";
            Text = "frmSalaUm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCima;
        private Button btnBaixo;
        private Button btnDireita;
        private Label label1;
    }
}