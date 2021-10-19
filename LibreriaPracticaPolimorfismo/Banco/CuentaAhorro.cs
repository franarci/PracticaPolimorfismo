using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(int idCuenta) : base(idCuenta) { }
        public override string calcularInteres()
        {
            return "Calculando interes de cuenta ahorro";
        }
    }
}
