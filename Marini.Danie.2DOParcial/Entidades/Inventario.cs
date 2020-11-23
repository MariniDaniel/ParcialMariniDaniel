using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public static class Inventario
    {
        static Queue<Pedido> pedidosEnPreparacion;
        static Queue<Pedido> pedidosEntregados;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        static Inventario()
        {
            pedidosEnPreparacion = new Queue<Pedido>();
            pedidosEntregados = new Queue<Pedido>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter cola de pedidos en preparacion
        /// </summary>
        public static Queue<Pedido> EnPreparacion
        {
            get { return pedidosEnPreparacion; }
        }

        /// <summary>
        /// Getter cola de pedidos entregados
        /// </summary>
        public static Queue<Pedido> Entregados
        {
            get { return pedidosEntregados; }
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Trae datos desde archivo y los agrega a la cola
        /// </summary>
        public static void Hardcodeo()
        {
            List<Pedido> pedidos = Leer();


            foreach (Pedido pedido in pedidos)
            {
                pedidosEnPreparacion.Enqueue(pedido);
            }


        }

        /// <summary>
        /// Serializa una lista de pedidos
        /// </summary>
        /// <returns>true si se guardo, false caso contrario</returns>
        public static bool Guardar()
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "inventario.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();

            List<Pedido> pedidos = new List<Pedido>();
            pedidos.Add(new Pedido(Pedido.EHelado.Almendrado, Pedido.EEnvio.Si, "Uruguay 2049", "011 11122323"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.BananaSplit));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Limon));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Oreo, Pedido.EEnvio.Si, "Pellegrini 1752", "4532234"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Frutilla));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.CremaDelCielo));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.DulceDeLeche, Pedido.EEnvio.Si, "Siempre Viva 23", "43212223"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Limon));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.DulceDeLeche, Pedido.EEnvio.Si, "Calchaqui 232", "42645448"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Almendrado));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Almendrado));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Frutilla, Pedido.EEnvio.Si, "Conesa 200", "20052091"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.Oreo));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EHelado.CremaDelCielo));

            return auxPedidos.Guardar(path, pedidos);
        }

        /// <summary>
        /// Deserializa un listado de pedidos
        /// </summary>
        /// <returns>una List<> de gustoHelado Pedido</returns>
        public static List<Pedido> Leer()
        {
            List<Pedido> datos = new List<Pedido>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "inventario.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();

            auxPedidos.Leer(path, out datos);

            return datos;

        }
        #endregion
    }
}
