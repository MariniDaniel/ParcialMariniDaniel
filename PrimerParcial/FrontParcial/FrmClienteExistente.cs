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
    public partial class FrmClienteExistente : Form
    {

        Clientes auxCliente;
        bool clickCliente = false;


        #region Properties
        /// <summary>
        /// Getter del objeto de tipo Cliente utilizado como auxiliar
        /// </summary>
        public Clientes AuxCliente
        {
            get { return this.auxCliente; }
        }

        #endregion


        /// <summary>
        /// Carga de listado datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            this.dtgCliente.DataSource = null;
            this.dtgCliente.DataSource = TiendaApu.MostrarListaPersonas();

        }


        public FrmClienteExistente()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (clickCliente == true)
            {
                MessageBox.Show("Se agrego correctamente cliente la compras","Correctamente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Debe seleccionar todos los campos antes de continuar","Seleccione",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void dtgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = (string)dtgCliente.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)dtgCliente.CurrentRow.Cells["Apellido"].Value;
            int dni = (int)dtgCliente.CurrentRow.Cells["Dni"].Value;

            //Clientes clienteAux = (Clientes)dtgCliente.CurrentRow.DataBoundItem;

            auxCliente = new Clientes(nombre, apellido, dni);
            this.lblCliente.Text = String.Concat("Cliente: ", apellido, ", ", nombre);
            clickCliente = true;
        }

        private void FrmClienteExistente_Load(object sender, EventArgs e)
        {
            CargarDatagrid();
        }
    }
}
