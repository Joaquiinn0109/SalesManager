﻿namespace App.Presentation
{
    partial class subMostrarEnvio
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 296);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subMostrarEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 295);
            Controls.Add(label1);
            Name = "subMostrarEnvio";
            Text = "subMostrarEnvio";
            Load += subMostrarEnvio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}