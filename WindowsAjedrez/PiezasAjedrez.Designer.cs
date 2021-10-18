namespace WindowsAjedrez
{
    partial class PiezasAjedrez
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
            this.btnTorre = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnPeon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTorre
            // 
            this.btnTorre.Location = new System.Drawing.Point(498, 214);
            this.btnTorre.Name = "btnTorre";
            this.btnTorre.Size = new System.Drawing.Size(92, 23);
            this.btnTorre.TabIndex = 5;
            this.btnTorre.Text = "Torre";
            this.btnTorre.UseVisualStyleBackColor = true;
            this.btnTorre.Click += new System.EventHandler(this.btnTorre_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.Location = new System.Drawing.Point(326, 214);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(92, 23);
            this.btnCaballo.TabIndex = 4;
            this.btnCaballo.Text = "Caballo";
            this.btnCaballo.UseVisualStyleBackColor = true;
            this.btnCaballo.Click += new System.EventHandler(this.btnCaballo_Click);
            // 
            // btnPeon
            // 
            this.btnPeon.Location = new System.Drawing.Point(167, 214);
            this.btnPeon.Name = "btnPeon";
            this.btnPeon.Size = new System.Drawing.Size(92, 23);
            this.btnPeon.TabIndex = 3;
            this.btnPeon.Text = "Peon";
            this.btnPeon.UseVisualStyleBackColor = true;
            this.btnPeon.Click += new System.EventHandler(this.btnPeon_Click);
            // 
            // PiezasAjedrez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTorre);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnPeon);
            this.Name = "PiezasAjedrez";
            this.Text = "PiezasAjedrez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTorre;
        private System.Windows.Forms.Button btnCaballo;
        private System.Windows.Forms.Button btnPeon;
    }
}