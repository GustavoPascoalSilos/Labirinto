namespace Labirinto
{
    partial class frmSalaSeis
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
            btnCima6 = new Button();
            btnDireita6 = new Button();
            btnBaixo6 = new Button();
            btnEsquerda6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCima6
            // 
            btnCima6.FlatAppearance.BorderSize = 0;
            btnCima6.FlatStyle = FlatStyle.Flat;
            btnCima6.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima6.Location = new Point(364, 12);
            btnCima6.Name = "btnCima6";
            btnCima6.Size = new Size(73, 43);
            btnCima6.TabIndex = 2;
            btnCima6.Text = "↑";
            btnCima6.UseVisualStyleBackColor = true;
            btnCima6.Click += btnCima6_Click;
            // 
            // btnDireita6
            // 
            btnDireita6.FlatAppearance.BorderSize = 0;
            btnDireita6.FlatStyle = FlatStyle.Flat;
            btnDireita6.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita6.Location = new Point(715, 203);
            btnDireita6.Name = "btnDireita6";
            btnDireita6.Size = new Size(73, 43);
            btnDireita6.TabIndex = 3;
            btnDireita6.Text = "→";
            btnDireita6.UseVisualStyleBackColor = true;
            // 
            // btnBaixo6
            // 
            btnBaixo6.FlatAppearance.BorderSize = 0;
            btnBaixo6.FlatStyle = FlatStyle.Flat;
            btnBaixo6.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo6.Location = new Point(364, 385);
            btnBaixo6.Name = "btnBaixo6";
            btnBaixo6.Size = new Size(73, 43);
            btnBaixo6.TabIndex = 4;
            btnBaixo6.Text = "↓";
            btnBaixo6.UseVisualStyleBackColor = true;
            btnBaixo6.Click += btnBaixo6_Click;
            // 
            // btnEsquerda6
            // 
            btnEsquerda6.FlatAppearance.BorderSize = 0;
            btnEsquerda6.FlatStyle = FlatStyle.Flat;
            btnEsquerda6.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsquerda6.Location = new Point(12, 203);
            btnEsquerda6.Name = "btnEsquerda6";
            btnEsquerda6.Size = new Size(73, 43);
            btnEsquerda6.TabIndex = 5;
            btnEsquerda6.Text = "←";
            btnEsquerda6.UseVisualStyleBackColor = true;
            btnEsquerda6.Click += btnEsquerda6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 188);
            label1.Name = "label1";
            label1.Size = new Size(122, 43);
            label1.TabIndex = 6;
            label1.Text = "SALA 6";
            // 
            // frmSalaSeis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEsquerda6);
            Controls.Add(btnBaixo6);
            Controls.Add(btnDireita6);
            Controls.Add(btnCima6);
            Name = "frmSalaSeis";
            Text = "frmSalaSeis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCima6;
        private Button btnDireita6;
        private Button btnBaixo6;
        private Button btnEsquerda6;
        private Label label1;
    }
}