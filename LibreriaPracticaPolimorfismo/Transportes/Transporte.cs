using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public abstract class Transporte
    {
        public int MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public double velocidad { get; set; }

        public abstract string acelerar();
        public abstract string desacelerar();
    }
}
