using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresas objEmpresa = new Empresas();
        
        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = new Empleado();
            objEmpleado.Nombre = txtBoxNombre.Text;
            objEmpleado.Apellido = txtBoxApellido.Text;
            Cargo objCargo = (Cargo)cmbCargo.SelectedValue;
            objEmpleado.Cargo = objCargo;
            objEmpleado.Cuil = int.Parse(txtBoxCuil.Text);
            objEmpleado.CantidadDeHijos = int.Parse(txtBoxCantidadDeHijos.Text);
            objEmpleado.Antiguedad = int.Parse(txtBoxAntiguedad.Text);

            
            objEmpleado.BonoPorAntiguedad = PlusPorAntiguedad(objCargo, objEmpleado);
            objEmpleado.BonoPorHijo = PlusPorHijo(objEmpleado);


            MessageBox.Show("El empleado " + objEmpleado.Nombre + " tiene un sueldo de $" + objEmpresa.CalcularSueldo(objEmpleado));

        }

        private BonoPorAntiguedad PlusPorAntiguedad(Cargo objcargo,Empleado objEmpleado)
        {
            BonoPorAntiguedad objBonoPorAntiguedad = new BonoPorAntiguedad();
            objBonoPorAntiguedad.BonoARecibir(objcargo,objEmpleado);
            return objBonoPorAntiguedad;
        }

        private BonoPorHijo PlusPorHijo(Empleado objEmpleado)
        {
            BonoPorHijo objBonoPorHijo = new BonoPorHijo();
            objBonoPorHijo.BonoARecibir(objEmpleado);
            return objBonoPorHijo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = objEmpresa.ListaDeCargos();
            cmbCargo.DisplayMember = "Nombre";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadDeHijos_Click(object sender, EventArgs e)
        {

        }
    }
}
