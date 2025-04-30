using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class BonoPorAntiguedad
    {
	    public float BonoARecibir(Cargo objCargo,Empleado objEmpleado)
		{
			return (float) (objCargo.SueldoBasico() * 0.07 * objEmpleado.Antiguedad);
		}

	}
}
