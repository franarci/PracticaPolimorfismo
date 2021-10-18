namespace WindowsAjedrez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPeon = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnTorre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPeon
            // 
            this.btnPeon.Location = new System.Drawing.Point(136, 210);
            this.btnPeon.Name = "btnPeon";
            this.btnPeon.Size = new System.Drawing.Size(92, 23);
            this.btnPeon.TabIndex = 0;
            this.btnPeon.Text = "Peon";
            this.btnPeon.UseVisualStyleBackColor = true;
            this.btnPeon.Click += new System.EventHandler(this.btnPeon_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.Location = new System.Drawing.Point(295, 210);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(92, 23);
            this.btnCaballo.TabIndex = 1;
            this.btnCaballo.Text = "Caballo";
            this.btnCaballo.UseVisualStyleBackColor = true;
            // 
            // btnTorre
            // 
            this.btnTorre.Location = new System.Drawing.Point(467, 210);
            this.btnTorre.Name = "btnTorre";
            this.btnTorre.Size = new System.Drawing.Size(92, 23);
            this.btnTorre.TabIndex = 2;
            this.btnTorre.Text = "Torre";
            this.btnTorre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTorre);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnPeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeon;
        private System.Windows.Forms.Button btnCaballo;
        private System.Windows.Forms.Button btnTorre;
    }
}

