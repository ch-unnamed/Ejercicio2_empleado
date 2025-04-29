using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class DirectorEjecutivo : Cargo
    {
        public override float SueldoBasico()
        {
            return 9000;
        }

        public DirectorEjecutivo()
        {
            this.Nombre = "Director Ejecutivo";
        }
    }
}
