﻿namespace Labirinto
{
    partial class frmPortal
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
            btnIniciar = new Button();
            btnVitoria = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Cyan;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(284, 154);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(220, 139);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Começar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnVitoria
            // 
            btnVitoria.BackColor = Color.DarkCyan;
            btnVitoria.FlatAppearance.BorderSize = 0;
            btnVitoria.FlatStyle = FlatStyle.Flat;
            btnVitoria.Location = new Point(766, 455);
            btnVitoria.Name = "btnVitoria";
            btnVitoria.Size = new Size(94, 38);
            btnVitoria.TabIndex = 1;
            btnVitoria.UseVisualStyleBackColor = false;
            btnVitoria.Click += btnVitoria_Click;
            // 
            // frmPortal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(778, 465);
            Controls.Add(btnVitoria);
            Controls.Add(btnIniciar);
            Name = "frmPortal";
            Text = "frmPortal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnVitoria;
    }
}