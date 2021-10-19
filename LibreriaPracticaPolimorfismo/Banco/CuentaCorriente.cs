using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPracticaPolimorfismo.Banco
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(int idCuenta) : base(idCuenta){}
        public override string calcularInteres()
        {
            return "Calculando interes de cuenta corriente";
        }
    }
}
