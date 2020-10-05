using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace FrontParcial
{
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float auxPrecio;
            int auxStock;
       

            if (float.TryParse(this.txtPrecio.Text, out auxPrecio) && int.TryParse(this.txtStock.Text, out auxStock) && !Validaciones.ValidarString(this.txtNombreProducto.Text))
            {

                Producto producto1 = new Producto(txtNombreProducto.Text, float.Parse(txtPrecio.Text), int.Parse(txtStock.Text));
                TiendaApu.AgregarProducto(producto1);
                MessageBox.Show("Se agrego correctamente el producto", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Verificar Campos...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

       
    }
}
