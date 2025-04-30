using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Empresas
    {
		private string _nombre = "Empresa";

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private Empleado _empleado;

		public Empleado Empleado
		{
			get { return _empleado; }
			set { _empleado = value; }
		}

		private List <Cargo> _cargo = new List <Cargo>();

		protected List <Cargo> Cargo
		{
			get { return _cargo ; }
			set { _cargo  = value; }
		}

		public List <Cargo> ListaDeCargos()
		{
			Asistente objAsistente = new Asistente();
			Operador objOperador = new Operador();
			EjecutivoDeCuenta objEjecutivoDeCuenta = new EjecutivoDeCuenta();
			Gerente objGerente = new Gerente();
			DirectorEjecutivo objDirectorEjecutivo = new DirectorEjecutivo();

			this.Cargo.Add(objAsistente);
			this.Cargo.Add(objOperador);
			this.Cargo.Add(objEjecutivoDeCuenta);
			this.Cargo.Add(objGerente);
			this.Cargo.Add(objDirectorEjecutivo);

			return this.Cargo;
		}

		public void CargarNombre(Empleado pEmpleado, string pNombre)
		{
			pEmpleado.Nombre = pNombre;
		}

		public void CargarApellido(Empleado pEmpleado, string pApellido)
		{
			pEmpleado.Apellido = pApellido;
		}

		public void ElegirCargo(Empleado pEmpleado, Cargo pCargo)
		{
			pEmpleado.Cargo = pCargo;
		}

        public void CargarCuil(Empleado pEmpleado, int pCuil)
        {
            pEmpleado.Cuil = pCuil;
        }

		public void CargarCantidadDeHijos(Empleado pEmpleado, int cantDeHijos)
		{
			pEmpleado.CantidadDeHijos = cantDeHijos;
		}

		public void CargarAntiguedad(Empleado pEmpleado, int cantDeAnios)
		{
			pEmpleado.Antiguedad = cantDeAnios;
		}

		public float CalcularSueldo(Empleado pEmpleado)
		{
			float sueldoFinal = 0;
			sueldoFinal = pEmpleado.Cargo.SueldoBasico() + pEmpleado.BonoPorAntiguedad.BonoARecibir(pEmpleado.Cargo, pEmpleado) + pEmpleado.BonoPorHijo.BonoARecibir(pEmpleado);
			return sueldoFinal;

		}
    }
}
