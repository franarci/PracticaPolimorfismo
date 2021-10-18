using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public abstract class Transporte
    {
        public Transporte(int maxFuel, int maxNroPasajeros, int velocidad)
        {
            MaxFuel = maxFuel;
            MaxNroDePasajeros = maxNroPasajeros;
            Velocidad = velocidad;
        }

        public int MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public int Velocidad { get; set; }

        public abstract string acelerar();
        public abstract string desacelerar();
    }
}
