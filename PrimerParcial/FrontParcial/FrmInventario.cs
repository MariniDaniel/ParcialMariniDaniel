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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

       

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregar = new FrmAgregarProducto();
            agregar.ShowDialog();
            ActualizarLista();
        }

     

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void FrmInventario_Load(object sender, EventArgs e)
        {

            ActualizarLista();


        }


        private void ActualizarLista()
        {
            dtgListaInventario.DataSource = null;
            dtgListaInventario.DataSource = TiendaApu.MostrarListaProductos();
        }

        private void stockMenorA10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {       
            dtgListaInventario.DataSource = null;
            dtgListaInventario.DataSource = TiendaApu.MostrarStock10();
        }

        private void mostrarTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
