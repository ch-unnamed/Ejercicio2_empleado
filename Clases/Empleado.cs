using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empleado
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private Cargo _cargo;

		public Cargo Cargo
		{
			get { return _cargo; }
			set { _cargo = value; }
		}

		private int _cuil;

		public int Cuil
		{
			get { return _cuil; }
			set { _cuil = value; }
		}

		private int _cantidadDeHijos;

		public int CantidadDeHijos
		{
			get { return _cantidadDeHijos; }
			set { _cantidadDeHijos = value; }
		}

		private int _antiguedad;

		public int Antiguedad
		{
			get { return _antiguedad; }
			set { _antiguedad = value; }
		}

		private BonoPorHijo _bonoPorHijo;

		public BonoPorHijo BonoPorHijo
		{
			get { return _bonoPorHijo; }
			set { _bonoPorHijo = value; }
		}

		private BonoPorAntiguedad _bonoPorAntiguedad;

		public BonoPorAntiguedad BonoPorAntiguedad
		{
			get { return _bonoPorAntiguedad; }
			set { _bonoPorAntiguedad = value; }
		}






	}
}
