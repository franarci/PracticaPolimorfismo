using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Animales
{
    public abstract class Animal
        
    {
        private int Edad;
        private double Altura;
        private double Peso;

        public Animal(int edad, double altura, double peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }

        public int getEdad {
            get
            {
                return Edad;
            }
        }
        public double getAltura {
            get
            {
                return Altura;
            }
        }
        public double getPeso {
            get
            {
                return Peso;
            }
        }
    }
}
