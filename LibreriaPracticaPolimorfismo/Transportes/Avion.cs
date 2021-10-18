using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public class Avion : Transporte
    {
        public int MaxAltitud { get; set; }
        public int NroDeMotores { get; set; }

        public Avion(int maxFuel, int maxNroPasajeros, int velocidad, int maxAltitud, int nroMotores) : base(maxFuel,maxNroPasajeros,velocidad)
        {
            MaxAltitud = maxAltitud;
            NroDeMotores = nroMotores;
        }

        public override string acelerar()
        {
            //TODO falta implementar acelerar() en avion
            return ("acelerando avion");
        }

        public override string desacelerar()
        {
            //TODO falta implementar desacelerar() en avion
            return ("desacelerando avion");
        }

        public string ascender()
        {
            //TODO falta implementar ascender()
            return ("ascendiendo avion");
        }
        public string descender()
        {
            //TODO falta implementar descender()
            return ("descendiendo avion");
        }

    }
}
