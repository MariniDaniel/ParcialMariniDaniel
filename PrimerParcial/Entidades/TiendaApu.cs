using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class TiendaApu
    {

        private TiendaApu() { }

        private static Dictionary<string, string> listaUsuarios;
        private static List<Venta> listaVentas;
        private static List<Persona> listaPersonas;
        private static List<Producto> listaProductos;
        private static Empleados empleadoLogueado;




        #region Constructor estatico
        /// <summary>
        /// Constructor estatico
        /// </summary>
        static TiendaApu()
        {
            listaVentas = new List<Venta>();
            listaUsuarios = new Dictionary<string, string>();
        }
        #endregion


        #region Singleton
        public static List<Producto> ListaProductos
        {
            get
            {
                if (listaProductos == null)
                {
                    listaProductos = new List<Producto>();

                }
                return listaProductos;
            }
            set { listaProductos = value; }
        }

        public static List<Persona> ListaPersonas
        {
            get
            {
                if (listaPersonas == null)
                {
                    listaPersonas = new List<Persona>();
                }
                return listaPersonas;
            }
            set { listaPersonas = value; }
        }


        #endregion



        



        /// <summary>
        ///  Getter lista de ventas
        /// </summary>
        public static List<Venta> ListaVentas
        {
            get { return listaVentas; }
        }


        /// <summary>
        /// Getter del Dictionary con los usuarios y sus claves
        /// </summary>
        public static Dictionary<string, string> ListaUsuarios
        {
            get { return listaUsuarios; }
        }


        public static Empleados EmpleadoLogueado
        {
            get { return empleadoLogueado; }
        }

        #region Metodos
        //Productos
        public static void AgregarProducto(Producto producto1)
        {
            ListaProductos.Add(producto1);


        }

        public static void BorrarProducto(Producto producto1)
        {

            ListaProductos.Remove(producto1);
        }

        public static List<Producto> MostrarListaProductos()
        {
            return ListaProductos;
        } 
        
        public static List<Venta> MostrarListaVentas()
        {
            return ListaVentas;
        }

        //Personas
        public static void AgregarCliente(Persona persona1)
        {
            ListaPersonas.Add(persona1);


        }

        public static void BorrarCliente(Persona persona1)
        {

            ListaPersonas.Remove(persona1);
        }


        public static List<Persona> MostrarListaPersonas()
        {
            return ListaPersonas;
        }


        public static void AgregarVenta(Venta venta1)
        {
            ListaVentas.Add(venta1);


        }



        public static List<Producto> MostrarStock10()//REVISANDO
        {
            List<Producto> auxProductos = new List<Producto>();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Stock < 10)
                {
                    auxProductos.Add(listaProductos[i]);
                }
            }
            return auxProductos;

        }







        /// <summary>
        /// Valida si el valor de stock solicitado es menor al disponible
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="auxCantidad"></param>
        /// <returns>Si hay stock disponible devuelve true. Caso contrario, false</returns>
        public static bool ValidarCantidad(int idProducto, int auxCantidad)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].IdProducto == idProducto && listaProductos[i].Stock >= auxCantidad)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Hardcodeo de usuarios para login de empleados
        /// </summary>
        public static void HardcodeoUsuarios()
        {
            listaUsuarios.Add("ironman", "ironman");
            listaUsuarios.Add("apu", "apu");
            listaUsuarios.Add("fdavila", "davila1");

        }

       



        /// <summary>
        /// Valida si el elemento recibido contiene el apellido "Simpson"
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <returns>True si es el apellido indicado, false caso contrario</returns>
        public static bool ValidarCliente(Clientes auxCliente)
        {

            if (auxCliente.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }








        /// <summary>
        /// Filtra las ventas generadas por el empleado ID ingresado por parametro
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>una List<> de tipo Venta</returns>
        public static List<Venta> VentasPorEmpleado(int idEmpleado)
        {
            List<Venta> auxListaVentas = new List<Venta>();

            foreach (Venta item in listaVentas)
            {
                if (item.Id == idEmpleado)
                {
                    auxListaVentas.Add(item);
                }
            }

            return auxListaVentas;
        }

        /// <summary>
        /// Verifica si en una lista de tipo Persona existen objetos de tipo Empleado y crea una sublista
        /// </summary>
        /// <returns>List<> de tipo Empleado</returns>
        public static List<Empleados> GetListaEmpleados()
        {
            List<Empleados> auxListaEmpleados = new List<Empleados>();

            foreach (Persona item in listaPersonas)
            {
                if (item is Empleados)
                {
                    auxListaEmpleados.Add((Empleados)item);
                }
            }

            return auxListaEmpleados;
        }

        /// <summary>
        /// Verifica si en una lista de tipo Persona existen objetos de tipo Clientes y crea una lista Auxiliar
        /// </summary>
        /// <returns>List<>AuxList de tipo Clientes</returns>
        public static List<Clientes> GetListaClientes()
        {
            List<Clientes> auxListaClientes = new List<Clientes>();

            foreach (Persona item in listaPersonas)
            {
                if (item is Clientes)
                {
                    auxListaClientes.Add((Clientes)item);
                }
            }

            return auxListaClientes;
        }

        /// <summary>
        /// Crea un objeto de tipo Empleado referente al empleado que inicio sesion
        /// </summary>
        /// <param name="usuarioActivo"></param>
        public static void AuxEmpleadoLogueado(string usuarioActivo)
        {
            List<Empleados> auxListaEmpleados;

            auxListaEmpleados = GetListaEmpleados();

            for (int i = 0; i < auxListaEmpleados.Count; i++)
            {
                if (auxListaEmpleados[i].Usuario == usuarioActivo)
                {
                    empleadoLogueado = auxListaEmpleados[i];
                    break;
                }
            }
        }


        /// <summary>
        /// Filtra las ventas generadas por el empleado ID ingresado por parametro
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>una List<> de tipo Venta</returns>
        public static List<Venta> GetListaVentas(int idEmpleado)
        {
            List<Venta> auxListaVentas = new List<Venta>();

            foreach (Venta item in listaVentas)
            {
                if (item.Id == idEmpleado)
                {
                    auxListaVentas.Add(item);
                }
            }

            return auxListaVentas;
        }



        /// <summary>
        /// Hace una carga instantanea de 3 compras
        /// </summary>
        public static void HardcodeoCompras()
        {
            Empleados[] auxEmpleado = new Empleados[3] { new Empleados("Tony", "Stark", 112312, 1, "ironman"), new Empleados("Ezequiel", "Oggioni", 543222, 2, "Oggioni1"), new Empleados("Federico ","Davila", 312312, 3,"fdavila") };

            Clientes[] auxCliente = new Clientes[3] { new Clientes("Ned", "Flanders", 333333), new Clientes("Ned", "Flanders", 333333), new Clientes("Homero", "Simpson", 123123) };

            string[] descripcion = new string[3] { "Cerveza Duff", "Caramelo","Revista"};

            float[] precio = new float[3] { 79, 54,12 };

            int[] idProducto = new int[3] {150, 200,120};

            for (int i = 0; i < auxCliente.Length; i++)
            {
                List<Compra> auxLista = new List<Compra>();
                auxLista.Add(new Compra(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new Compra(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new Compra(descripcion[i], precio[i], idProducto[i]));
                listaVentas.Add(new Venta(auxEmpleado[i], auxCliente[i], auxLista, (precio[i] * 3)));
            }
        }


        /// <summary>
        /// Hace una carga instantanea de 3 empleados
        /// </summary>
        public static void HardcodeoEmpleados()
        {
            string[] nombre = new string[3] { "Tony", "Apu", "Federico" };
            string[] apellido = new string[3] { "Stark", "Nahasapeemapetilon", "Davila" };
            int[] id = new int[3] { 1, 2, 3 };
            int[] dni = new int[3] { 112312, 543222, 312312 };
            string[] usuario = new string[3] { "ironman", "apu", "fdavila" };

            for (int i = 0; i < 3; i++)
            {
                listaPersonas.Add(new Empleados(nombre[i], apellido[i], dni[i],id[i], usuario[i]));
            }
        }

        #endregion

    }
}
