using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Conejo : Animal
    {
        public double LongitudOrejas { get; set; }
        public Conejo(int edad, double altura, double peso, double longOrejas) : base(edad, altura, peso)
        {
            LongitudOrejas = longOrejas;
        }
        public override string imprimirComida()
        {
            return ("Plantas");
        }
    }
}
