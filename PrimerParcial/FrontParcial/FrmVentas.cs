using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontParcial
{
    public partial class FrmVentas : Form
    {

        List<Venta> auxListaVentas;

      
        public FrmVentas()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Carga inicial del datagridview de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            this.dtgListaEmpleados.DataSource = TiendaApu.GetListaEmpleados();
        }

        /// <summary>
        /// Carga del datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            this.dtgListaVentas.DataSource = null;
            this.dtgListaVentas.DataSource = auxListaVentas;
        }

        /// <summary>
        /// Utiliza el id del empleado seleccionado por el usuario para mostrar el listado de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgListaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            int idEmpleado = (int)this.dtgListaEmpleados.CurrentRow.Cells["IdEmpleado"].Value;
            string nombre = (string)this.dtgListaEmpleados.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)this.dtgListaEmpleados.CurrentRow.Cells["Apellido"].Value;
            

            auxListaVentas = TiendaApu.GetListaVentas(idEmpleado);

            this.lblEmpleado.Text = String.Concat("Empleado: ",nombre, ", ", apellido);
            this.CargarDatagrid();
        }



        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
