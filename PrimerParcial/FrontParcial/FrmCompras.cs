using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontParcial
{
    public partial class FrmCompras : Form
    {

        List<Compra> listaCompras;
        double auxMontoTotal = 0;
        SoundPlayer auxSonido;
        string directorio = Directory.GetCurrentDirectory();

        #region Properties
        /// <summary>
        /// Getter monto total
        /// </summary>
        public double MontoTotal
        {
            get { return this.auxMontoTotal; }
        }

        /// <summary>
        /// Getter Lista de compras
        /// </summary>
        public List<Compra> ListaCompras
        {
            get { return this.listaCompras; }
        }
        #endregion


        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmCompras()
        {
            InitializeComponent();
            auxSonido = new SoundPlayer();
        }
        #endregion



        private void ActualizarLista()
        {
            dtgListaInventario.DataSource = null;
            dtgListaInventario.DataSource = TiendaApu.MostrarListaProductos();
        }

        private void ActualizarListaCompra()
        {
            dtgCompras.DataSource = null;
            dtgCompras.DataSource = this.listaCompras;

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            listaCompras = new List<Compra>();          
            ActualizarLista();
            auxSonido.SoundLocation = String.Concat(directorio, "/duff.wav");

        }


        /// <summary>
        /// Agrego producto a la lista de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgListaInventario_DoubleClick(object sender, EventArgs e)
        {
            int auxCantidad;

            if (int.TryParse(this.txtStock.Text, out auxCantidad))
            {

                Producto productito = (Producto)dtgListaInventario.CurrentRow.DataBoundItem;

                if (!Validaciones.CerosYnegativos(auxCantidad))
                {
                    if (TiendaApu.ValidarCantidad(productito.IdProducto, auxCantidad))
                    {
                        //Carga la cantidad solicitada de productos a la lista

                        for (int i = 0; i < auxCantidad; i++)
                        {
                            listaCompras.Add(new Compra(productito.NombreProducto, productito.PrecioProducto,
                                                                                         productito.IdProducto));
                        }



                        // Recorre la lista de productos y cuando la encuentra, reduce el stock 

                        for (int i = 0; i < TiendaApu.ListaProductos.Count; i++)
                        {
                            if (productito.IdProducto == TiendaApu.ListaProductos[i].IdProducto)
                            {
                                TiendaApu.ListaProductos[i].Stock -= auxCantidad;
                            }
                        }

                        // actualiza el monto total, los datagridviews y el monto mostrado a traves del label

                        auxMontoTotal += (productito.PrecioProducto * auxCantidad);
                        lblMontoTotal.Text = auxMontoTotal.ToString();
                        ActualizarLista();
                        ActualizarListaCompra();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock del producto solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("La cantidad no puede ser 0 ni un numero negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, agregue cantidad antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.txtStock.Clear();

        }



        /// <summary>
        /// Al hacer doble click sobre una fila, elimina el elemento de la lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dtgCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            Compra compraPiola = (Compra)dtgCompras.CurrentRow.DataBoundItem;

            // recorre la lista y elimina el objeto

            for (int i = 0; i < listaCompras.Count; i++)
            {
                if (listaCompras[i].IdCompra == compraPiola.IdCompra)
                {
                    listaCompras.Remove(listaCompras[i]);
                    break;
                }
            }

            // elimina el valor del monto total

            auxMontoTotal -= compraPiola.Precio;

            // recorre el listado de productos, y aumenta el stock del objeto eliminado

            for (int i = 0; i < TiendaApu.ListaProductos.Count; i++)
            {
                if (TiendaApu.ListaProductos[i].IdProducto == compraPiola.IdCompra)
                {
                    TiendaApu.ListaProductos[i].Stock += 1;
                }
            }

            // actualiza los datagridviews y el label que muestra el valor total

            lblMontoTotal.Text = auxMontoTotal.ToString();
            ActualizarLista();
            ActualizarListaCompra();


        }


        /// <summary>
        /// Cliente existente en momento de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteExiste_Click(object sender, EventArgs e)
        {
            if (auxMontoTotal > 0)
            {
                FrmClienteExistente auxClienteExistente = new FrmClienteExistente();

                if (auxClienteExistente.ShowDialog() == DialogResult.OK)
                {
                    if (TiendaApu.ValidarCliente(auxClienteExistente.AuxCliente))
                    {


                        TiendaApu.ListaVentas.Add(new Venta(TiendaApu.EmpleadoLogueado, auxClienteExistente.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));
                        // si es miembro de la familia Simpson aplica descuento

                        MessageBox.Show("Por ser miembro de la familia Simpson tiene un descuentos del 13%!!", "Descuento!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        double descuento = (auxMontoTotal) * 13 / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}", "Informacion",
                        montoOriginal, descuento, auxMontoTotal, MessageBoxButtons.OK, MessageBoxIcon.Exclamation));


                        Venta venta1 = (new Venta(TiendaApu.EmpleadoLogueado, auxClienteExistente.AuxCliente,this.listaCompras, this.auxMontoTotal));
                        TiendaApu.AgregarVenta(venta1);

              
                        // genera comprobante de compra

                        StreamWriter auxComprobante = new StreamWriter(String.Concat(directorio, "/ticketCompra"));
                        auxComprobante.WriteLine(DateTime.Now.ToLongDateString());
                        auxComprobante.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                        foreach (var item in this.listaCompras)
                        {
                            auxComprobante.WriteLine("Item: {0: -10} Precio: ${1:###,##.00}", item.Descripcion, item.Precio);
                        }
                        auxComprobante.WriteLine("Monto: ${0:###,##.00}", montoOriginal);
                        auxComprobante.WriteLine("Descuento SIMPSON: ${0:###,##.00}", descuento);
                        auxComprobante.WriteLine("Total a abonar: ${0:###,##.00}", auxMontoTotal);
                        auxComprobante.WriteLine("Gracias! Vuelva prontosss");
                        auxComprobante.Close();
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // genera comprobante de compra

                        StreamWriter auxComprobante = new StreamWriter(String.Concat(directorio, "/ticketCompra"));

                        auxComprobante.WriteLine(DateTime.Now.ToLongDateString());
                        auxComprobante.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                        auxComprobante.WriteLine(String.Format($"Cliente: {auxClienteExistente.AuxCliente.Nombre} {auxClienteExistente.AuxCliente.Apellido}"));
                        foreach (var item in this.listaCompras)
                        {
                            auxComprobante.WriteLine("Item: {0: -10} Precio: ${1:###,##.00}", item.Descripcion, item.Precio);
                        }
                        auxComprobante.WriteLine("Total a abonar: ${0:###,##.00}", auxMontoTotal);
                        auxComprobante.WriteLine("Gracias! Vuelva prontosss");

                        auxComprobante.Close();
                    }

                    // Agrega venta a la lista de ventas 

                    TiendaApu.ListaVentas.Add(new Venta(TiendaApu.EmpleadoLogueado, auxClienteExistente.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                    auxSonido.Play();
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {

            if (auxMontoTotal > 0)
            {
                FrmClienteNuevo auxClienteNuevo = new FrmClienteNuevo();


                if (auxClienteNuevo.ShowDialog() == DialogResult.OK)
                {
                    if (TiendaApu.ValidarCliente(auxClienteNuevo.AuxCliente))
                    {
                        //Agrega venta, a la lista de ventas 

                        TiendaApu.ListaVentas.Add(new Venta(TiendaApu.EmpleadoLogueado, auxClienteNuevo.AuxCliente, this.listaCompras, this.auxMontoTotal));
                  
                        MessageBox.Show("En Hora buena por ser miembro de la familia Simpson tiene un descuentos del 13%", "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        double descuento = (auxMontoTotal * 13) / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}",
                       montoOriginal, descuento, auxMontoTotal), "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), "Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Agrega venta, a la lista de ventas 

                        TiendaApu.ListaVentas.Add(new Venta(TiendaApu.EmpleadoLogueado, auxClienteNuevo.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                    }

                    auxSonido.Play();
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
