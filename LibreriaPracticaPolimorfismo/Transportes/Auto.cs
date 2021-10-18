using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Transportes
{
    public class Auto : Transporte
    {
        public string Modelo { get; set; }

        public Auto(int maxFuel, int maxNroPasajeros, int velocidad, string modelo) : base(maxFuel, maxNroPasajeros, velocidad)
        {
            Modelo = modelo;
        }

        public override string acelerar()
        {
            //TODO falta implementar acelerar() en auto
            return ("acelerando auto");
        }

        public override string desacelerar()
        {
            //TODO falta implementar desacelerar() en auto
            return ("desacelerando auto");
        }

        public string doblarAIzq()
        {
            //TODO falta implementar doblarAIzq()
            return ("doblando a izquierda");
        }
        public string doblarADer()
        {
            //TODO falta implementar doblarADer()
            return ("doblando a derecha");
        }
    }
}

    
