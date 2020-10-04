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
            Producto producto1 = new Producto(txtNombreProducto.Text,float.Parse(txtPrecio.Text),int.Parse(txtStock.Text));
            TiendaApu.AgregarProducto(producto1);


            MessageBox.Show("Se agrego correctamente el producto","Agregado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            this.Close();
         
        }

        
    }
}
