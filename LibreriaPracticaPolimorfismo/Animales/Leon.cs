using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public class Leon : Animal
    {
        public double TamañoColmillos { get; set; }
        public Leon(int edad, double altura, double peso, double tamColmillos) : base(edad,altura,peso)
        {
            TamañoColmillos = tamColmillos;
        }
        public override string imprimirComida()
        {
            return("Carne");
        }
    }
}
