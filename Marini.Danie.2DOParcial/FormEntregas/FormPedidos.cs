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
using Excepciones;

namespace FormEntregas
{
    public partial class FormPedidos : Form
    {
        Pedido auxPedido;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormPedidos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Asigna el origen de datos de los combobox utilizados en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Pedido.EHelado));
            this.cmbDelivery.DataSource = Enum.GetValues(typeof(Pedido.EEnvio));
        }

        /// <summary>
        /// Limpia la pantalla
        /// </summary>
        private void Limpiar()
        {
            this.txtDomicilio.Clear();
            this.txtTelefono.Clear();
        }

        /// <summary>
        /// Llamada al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga un nuevo pedido a la lista de entregas pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Pedido.EEnvio)this.cmbDelivery.SelectedValue == Pedido.EEnvio.No)
                {
                    auxPedido = new Pedido((Pedido.EHelado)this.cmbTipo.SelectedItem);
                    Inventario.EnPreparacion.Enqueue(auxPedido);
                    MessageBox.Show("Cargado con exito");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (!String.IsNullOrEmpty(this.txtDomicilio.Text) && !String.IsNullOrEmpty(this.txtTelefono.Text))
                    {
                        auxPedido = new Pedido((Pedido.EHelado)this.cmbTipo.SelectedItem, Pedido.EEnvio.Si, this.txtDomicilio.Text, this.txtTelefono.Text);
                        Inventario.EnPreparacion.Enqueue(auxPedido);
                        MessageBox.Show("Cargado con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        throw new PedidosException("Por favor, completar todos los campos para confirmar delivery");
                    }

                }
            }
            catch (PedidosException exc)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(exc.Message, "Pedidos");
            }
            catch (Exception exc)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(exc.Message, "Pedidos");
            }
            finally
            {
                this.Limpiar();
            }
        }
    }
}
