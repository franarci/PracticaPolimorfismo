using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPracticaPolimorfismo.Animales;

namespace WindowsForms
{
    public partial class Animales : Form
    {
        public Animales()
        {
            InitializeComponent();
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(10, 1.50, 90.59,7.6);
            MessageBox.Show(leon.imprimir() + ", Alimentacion: "+ leon.imprimirComida());
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(7, 0.50, 3.1, 15.9);
            MessageBox.Show(conejo.imprimir() + ", Alimentacion: " + conejo.imprimirComida());
        }
    }
}
