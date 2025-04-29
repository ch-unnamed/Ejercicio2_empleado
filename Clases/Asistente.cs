using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Asistente : Cargo
    {
        public override float SueldoBasico()
        {
            return 1000;
        }

        public Asistente()
        {
            this.Nombre = "Asistente";
        }
    }
}
