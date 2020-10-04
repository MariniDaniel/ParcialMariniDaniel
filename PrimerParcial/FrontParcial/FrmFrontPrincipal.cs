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
    public partial class FrmFrontPrincipal : Form
    {
        bool banderaLog = false;

        public FrmFrontPrincipal()
        {
            InitializeComponent();
        }



        private void FrmFrontPrincipal_Load(object sender, EventArgs e)
        {
            HardcodeoClientes();
            AgregarProductos();
            FrmLogin login = new FrmLogin();


            if (login.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Logueo exitoso", "Excelenteee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                banderaLog = true;
            }
            else
            {
                this.Close();
            }



        }


        /// <summary>
        /// Hace una carga instantanea de 5 clientes
        /// </summary>
        private void HardcodeoClientes()
        {

            Persona persona1 = new Persona("Homero", "Simpson", 15455);
            Persona persona2 = new Persona("Barney", "Gomez", 123123);
            Persona persona3 = new Persona("Montgomery", "Burns", 00018);
            Persona persona4 = new Persona("Ned", "Flanders", 123123);
            Persona persona5 = new Persona("Bart", "Simpson", 12354);

            TiendaApu.AgregarCliente(persona1);
            TiendaApu.AgregarCliente(persona2);
            TiendaApu.AgregarCliente(persona3);
            TiendaApu.AgregarCliente(persona4);
            TiendaApu.AgregarCliente(persona5);

        }

        private void AgregarProductos()
        {


            Producto producto1 = new Producto("Cerveza Duff", 35, 99, 1);//PROBANDO PRUEBA SOLO
            Producto producto2 = new Producto("PAPITAS", 15, 45, 2);
            Producto producto3 = new Producto("Cereales Krusty", 60, 23, 3);
            Producto producto4 = new Producto("Buzz Cola", 20, 9, 4);
            Producto producto5 = new Producto("Squishees", 15, 10, 5);
            Producto producto6 = new Producto("Radioctive Comics", 300, 3, 6);
            Producto producto7 = new Producto("Rosquillas", 5, 150, 7);
            Producto producto8 = new Producto("Caramelos", 2, 999, 8);
            Producto producto9 = new Producto("Revistas", 15, 30, 9);
            Producto producto10 = new Producto("Armas", 500, 5, 10);
            Producto producto11 = new Producto("Raspados", 10, 500, 11);
            Producto producto12 = new Producto("Purpurina", 5, 200, 12);
            Producto producto13 = new Producto("Papel maché", 5, 200, 13);
            Producto producto14 = new Producto("Flores", 5, 25, 14);
            Producto producto15 = new Producto("Boletos de loteria", 5, 500, 15);
            Producto producto16 = new Producto("Patatas fritas", 40, 7, 16);
            Producto producto17 = new Producto("Pasteles lunares", 50, 20, 17);
            Producto producto18 = new Producto("Fruta", 15, 33, 18);
            Producto producto19 = new Producto("Leche de 1961", 1, 68, 19);
            Producto producto20 = new Producto("Jamón rancio", 1, 78, 20);
            Producto producto21 = new Producto("Chupelupes", 3, 78, 21);
            Producto producto22 = new Producto("Avioncitos", 120, 23, 22);
            Producto producto23 = new Producto("Horoscopos", 13, 52, 23);
            Producto producto24 = new Producto("Libros educativos", 19, 45, 24);
            Producto producto25 = new Producto("Revistas", 10, 78, 25);
            Producto producto26 = new Producto("Pan de astronauta", 30, 6, 26);
            Producto producto27 = new Producto("Telefonos moviles", 800, 11, 27);
            Producto producto28 = new Producto("Butterfinger", 70, 15, 28);
            Producto producto29 = new Producto("Coca Cola", 80, 68, 29);
            Producto producto30 = new Producto("Lapiz", 5, 674, 30);



            TiendaApu.AgregarProducto(producto1);
            TiendaApu.AgregarProducto(producto2);
            TiendaApu.AgregarProducto(producto3);
            TiendaApu.AgregarProducto(producto4);
            TiendaApu.AgregarProducto(producto5);
            TiendaApu.AgregarProducto(producto6);
            TiendaApu.AgregarProducto(producto7);
            TiendaApu.AgregarProducto(producto8);
            TiendaApu.AgregarProducto(producto9);
            TiendaApu.AgregarProducto(producto10);
            TiendaApu.AgregarProducto(producto11);
            TiendaApu.AgregarProducto(producto12);
            TiendaApu.AgregarProducto(producto13);
            TiendaApu.AgregarProducto(producto14);
            TiendaApu.AgregarProducto(producto15);
            TiendaApu.AgregarProducto(producto16);
            TiendaApu.AgregarProducto(producto17);
            TiendaApu.AgregarProducto(producto18);
            TiendaApu.AgregarProducto(producto19);
            TiendaApu.AgregarProducto(producto20);
            TiendaApu.AgregarProducto(producto21);
            TiendaApu.AgregarProducto(producto23);
            TiendaApu.AgregarProducto(producto24);
            TiendaApu.AgregarProducto(producto25);
            TiendaApu.AgregarProducto(producto26);
            TiendaApu.AgregarProducto(producto27);
            TiendaApu.AgregarProducto(producto28);
            TiendaApu.AgregarProducto(producto29);
            TiendaApu.AgregarProducto(producto30);
        }




        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            FrmCompras comprar = new FrmCompras();
            comprar.ShowDialog();


        }
    }
}
