namespace WindowsForms
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
            this.btnLoro = new System.Windows.Forms.Button();
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
            // btnLoro
            // 
            this.btnLoro.Location = new System.Drawing.Point(387, 203);
            this.btnLoro.Name = "btnLoro";
            this.btnLoro.Size = new System.Drawing.Size(75, 23);
            this.btnLoro.TabIndex = 2;
            this.btnLoro.Text = "Loro";
            this.btnLoro.UseVisualStyleBackColor = true;
            this.btnLoro.Click += new System.EventHandler(this.btnLoro_Click);
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoro);
            this.Controls.Add(this.btnConejo);
            this.Controls.Add(this.btnLeon);
            this.Name = "Animales";
            this.Text = "Animales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeon;
        private System.Windows.Forms.Button btnConejo;
        private System.Windows.Forms.Button btnLoro;
    }
}