namespace Labirinto
{
    partial class frmSalaCinco
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
            btnBaixo5 = new Button();
            btnDireita5 = new Button();
            btnCima5 = new Button();
            btnEsquerda5 = new Button();
            label2 = new Label();
            label3 = new Label();
            btnSeta = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 114);
            label1.Name = "label1";
            label1.Size = new Size(121, 43);
            label1.TabIndex = 0;
            label1.Text = "SALA 5";
            // 
            // btnBaixo5
            // 
            btnBaixo5.FlatAppearance.BorderSize = 0;
            btnBaixo5.FlatStyle = FlatStyle.Flat;
            btnBaixo5.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaixo5.Location = new Point(351, 383);
            btnBaixo5.Name = "btnBaixo5";
            btnBaixo5.Size = new Size(73, 43);
            btnBaixo5.TabIndex = 7;
            btnBaixo5.Text = "↓";
            btnBaixo5.UseVisualStyleBackColor = true;
            btnBaixo5.MouseEnter += btnBaixo_MouseEnter;
            // 
            // btnDireita5
            // 
            btnDireita5.FlatAppearance.BorderSize = 0;
            btnDireita5.FlatStyle = FlatStyle.Flat;
            btnDireita5.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDireita5.Location = new Point(715, 182);
            btnDireita5.Name = "btnDireita5";
            btnDireita5.Size = new Size(73, 43);
            btnDireita5.TabIndex = 8;
            btnDireita5.Text = "→";
            btnDireita5.UseVisualStyleBackColor = true;
            btnDireita5.Click += btnDireita5_Click;
            // 
            // btnCima5
            // 
            btnCima5.FlatAppearance.BorderSize = 0;
            btnCima5.FlatStyle = FlatStyle.Flat;
            btnCima5.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCima5.Location = new Point(351, 12);
            btnCima5.Name = "btnCima5";
            btnCima5.Size = new Size(73, 43);
            btnCima5.TabIndex = 9;
            btnCima5.Text = "↑";
            btnCima5.UseVisualStyleBackColor = true;
            btnCima5.MouseEnter += btnCima5_MouseEnter;
            // 
            // btnEsquerda5
            // 
            btnEsquerda5.FlatAppearance.BorderSize = 0;
            btnEsquerda5.FlatStyle = FlatStyle.Flat;
            btnEsquerda5.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsquerda5.Location = new Point(12, 181);
            btnEsquerda5.Name = "btnEsquerda5";
            btnEsquerda5.Size = new Size(73, 43);
            btnEsquerda5.TabIndex = 10;
            btnEsquerda5.Text = "←";
            btnEsquerda5.UseVisualStyleBackColor = true;
            btnEsquerda5.MouseEnter += button3_MouseEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 220);
            label2.Name = "label2";
            label2.Size = new Size(586, 37);
            label2.TabIndex = 11;
            label2.Text = "ANTES DE ESCOLHER 1 LADO, PENSE BEM ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(102, 266);
            label3.Name = "label3";
            label3.Size = new Size(238, 37);
            label3.TabIndex = 12;
            label3.Text = "SOMENTE 1 DAS ";
            // 
            // btnSeta
            // 
            btnSeta.FlatAppearance.BorderSize = 0;
            btnSeta.FlatStyle = FlatStyle.Flat;
            btnSeta.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeta.Location = new Point(325, 250);
            btnSeta.Name = "btnSeta";
            btnSeta.Size = new Size(66, 53);
            btnSeta.TabIndex = 13;
            btnSeta.Text = "→";
            btnSeta.UseVisualStyleBackColor = true;
            btnSeta.Click += btnSeta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(397, 266);
            label4.Name = "label4";
            label4.Size = new Size(227, 37);
            label4.TabIndex = 14;
            label4.Text = "É VERDADEIRA";
            // 
            // frmSalaCinco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnSeta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEsquerda5);
            Controls.Add(btnCima5);
            Controls.Add(btnDireita5);
            Controls.Add(btnBaixo5);
            Controls.Add(label1);
            Name = "frmSalaCinco";
            Text = "frmSalaCinco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBaixo5;
        private Button btnDireita5;
        private Button btnCima5;
        private Button btnEsquerda5;
        private Label label2;
        private Label label3;
        private Button btnSeta;
        private Label label4;
    }
}