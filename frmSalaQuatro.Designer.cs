namespace Labirinto
{
    partial class frmSalaQuatro
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
            btnVoltar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtResposta = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 69);
            label1.Name = "label1";
            label1.Size = new Size(578, 41);
            label1.TabIndex = 0;
            label1.Text = "VOCÊ ESTÁ A UMA RESPOSTA DA VITÓRIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(225, -4);
            label2.Name = "label2";
            label2.Size = new Size(343, 50);
            label2.TabIndex = 1;
            label2.Text = "SALA DA VITÓRIA";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Yellow;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(12, 397);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 139);
            label3.Name = "label3";
            label3.Size = new Size(702, 21);
            label3.TabIndex = 3;
            label3.Text = "Juntos temos 1000 vacas, VOCÊ que está lendo tem 950 vacas a mais que EU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(259, 185);
            label4.Name = "label4";
            label4.Size = new Size(238, 21);
            label4.TabIndex = 4;
            label4.Text = "Quantas vacas EU tenho?";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(315, 268);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(125, 27);
            txtResposta.TabIndex = 5;
            txtResposta.KeyPress += txtResposta_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(606, 397);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmSalaQuatro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(txtResposta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSalaQuatro";
            Text = "frmSalaQuatro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVoltar;
        private Label label3;
        private Label label4;
        private TextBox txtResposta;
        private Button btnConfirmar;
    }
}