using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPracticaPolimorfismo.Ajedrez.Models;

namespace WindowsAjedrez
{
    public partial class PiezasAjedrez : Form
    {
        public PiezasAjedrez()
        {
            InitializeComponent();
        }

        private void btnPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();
            MessageBox.Show(peon.mover());
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.mover());
        }

        private void btnTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show(torre.mover());
        }
    }
}
