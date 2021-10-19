using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Loro : Animal
    {
        public double Coloracion { get; set; }
        public Loro(int edad, double altura, double peso, double coloracion) : base(edad, altura, peso)
        {
            Coloracion = coloracion;
        }
        public override string imprimirComida()
        {
            return ("Frutas");
        }
    }
}
