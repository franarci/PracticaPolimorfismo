using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Ajedrez.Models
{
    public class Caballo : PiezaAjedrez
    {
        public override string mover()
        {
            return "El caballo solo se mueve en L";
        }
    }
}
