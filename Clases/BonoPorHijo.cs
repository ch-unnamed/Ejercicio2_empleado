using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class BonoPorHijo
    {
        public float BonoARecibir(Empleado objEmpleado)
        {
            return (float)(100 * objEmpleado.CantidadDeHijos);
        }
    }
}
