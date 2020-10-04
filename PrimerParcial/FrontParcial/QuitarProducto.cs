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
    public partial class QuitarProducto : Form
    {
        public QuitarProducto()
        {
            InitializeComponent();
            
        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void QuitarProducto_Load(object sender, EventArgs e)
        {
           
            ActualizarLista();

        }

        private void ActualizarLista()
        {
            dtgLista.DataSource = null;
            dtgLista.DataSource = TiendaApu.MostrarListaProductos();  
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
        
        }

      
    }
}
