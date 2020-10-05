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
    public partial class FrmClienteNuevo : Form
    {
        Clientes auxCliente;

        #region Properties
        /// <summary>
        /// Getter del objeto de tipo Clientes utilizado como auxiliar
        /// </summary>
        public Clientes AuxCliente
        {
            get { return auxCliente; }
        }
        #endregion


        public FrmClienteNuevo()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
               this.Close();           
        }

        private void btnDarDeAlta_Click(object sender, EventArgs e)
        {
            int auxDni;

            if (!Validaciones.ValidarString(this.txtApellido.Text) && !Validaciones.ValidarString(this.txtNombre.Text) &&
                int.TryParse(this.txtDni.Text, out auxDni))
            {
                if (!Validaciones.CerosYnegativos(auxDni))
                {
                    auxCliente = new Clientes(this.txtNombre.Text, this.txtApellido.Text, auxDni);

                    if (TiendaApu.GetListaClientes() != auxCliente)
                    {
                      
                        TiendaApu.ListaPersonas.Add(auxCliente);
                        MessageBox.Show("Cliente cargados con exito!","Dado De Alta",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Cliente registrados previamentes, los datos no seran duplicados!","Cliente Duplicado",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }

                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Verificar Documento","Verificar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados antes de continuar","Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
