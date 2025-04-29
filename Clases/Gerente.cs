using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gerente : Cargo
    {
        public override float SueldoBasico()
        {
            return 5000;
        }
        public Gerente()
        {
            this.Nombre = "Gerente";
        }
    }
}
