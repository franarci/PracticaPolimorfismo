﻿namespace WindowsForms
{
    partial class Animales
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
            this.btnLeon = new System.Windows.Forms.Button();
            this.btnConejo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeon
            // 
            this.btnLeon.Location = new System.Drawing.Point(144, 203);
            this.btnLeon.Name = "btnLeon";
            this.btnLeon.Size = new System.Drawing.Size(75, 23);
            this.btnLeon.TabIndex = 0;
            this.btnLeon.Text = "Leon";
            this.btnLeon.UseVisualStyleBackColor = true;
            this.btnLeon.Click += new System.EventHandler(this.btnLeon_Click);
            // 
            // btnConejo
            // 
            this.btnConejo.Location = new System.Drawing.Point(264, 203);
            this.btnConejo.Name = "btnConejo";
            this.btnConejo.Size = new System.Drawing.Size(75, 23);
            this.btnConejo.TabIndex = 1;
            this.btnConejo.Text = "Conejo";
            this.btnConejo.UseVisualStyleBackColor = true;
            this.btnConejo.Click += new System.EventHandler(this.btnConejo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConejo);
            this.Controls.Add(this.btnLeon);
            this.Name = "Animales";
            this.Text = "Animales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeon;
        private System.Windows.Forms.Button btnConejo;
        private System.Windows.Forms.Button button3;
    }
}