using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Operador : Cargo
    {

        public override float SueldoBasico()
        {
            return 1500;
        }
        public Operador()
        {
            this.Nombre = "Operador";
        }
    }
}
