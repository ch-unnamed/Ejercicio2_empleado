using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class EjecutivoDeCuenta : Cargo
    {
        public override float SueldoBasico()
        {
            return 2000;
        }

        public EjecutivoDeCuenta()
        {
            this.Nombre = "Ejecutivo de cuenta";
        }
    }
}
