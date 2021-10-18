using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Ajedrez.Models
{
    public class Torre : PiezaAjedrez
    {
        public override string mover()
        {
            return "La torre mueve horizontal o verticalmente los espacios que quiera";
        }
    }
}
