using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public abstract class Cuenta
    {
        public int IdCuenta { get; set; }
        
        public Cuenta(int idCuenta)
        {
            IdCuenta = idCuenta;
        }
        public abstract string calcularInteres();
    }
}
