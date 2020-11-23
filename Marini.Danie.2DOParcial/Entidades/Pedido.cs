using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public class Pedido
    {
        public enum EHelado
        {
            DulceDeLeche,
            BananaSplit,
            Oreo,
            CremaDelCielo,
            Almendrado,
            Limon,
            Frutilla
        }

        public enum EEnvio
        {
            No,
            Si
        }

        EHelado gustoHelado;
        EEnvio conEnvio;
        string numeroPedido;
        string domicilioEntrega;
        string telefonoEntrega;

        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        private Pedido()
        {
            this.numeroPedido = DateTime.Now.ToString("HHmmss");
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gusto"></param>
        public Pedido(EHelado gusto) : this()
        {
            this.gustoHelado = gusto;
            this.conEnvio = EEnvio.No;
            this.domicilioEntrega = "SIN DIRECCION";
            this.telefonoEntrega = "SIN TELEFONO";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gusto"></param>
        /// <param name="conEnvio"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        public Pedido(EHelado gusto, EEnvio conEnvio, string domicilio, string telefono) : this()
        {
            this.conEnvio = conEnvio;
            this.domicilioEntrega = domicilio;
            this.telefonoEntrega = telefono;
            this.gustoHelado = gusto;
        }

        /// <summary>
        /// Constructor agregando numero pedido
        /// </summary>
        /// <param name="gusto"></param>
        /// <param name="nroPedido"></param>
        /// <param name="conEnvio"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        public Pedido(EHelado gusto, string nroPedido, EEnvio conEnvio, string domicilio, string telefono) : this(gusto, conEnvio, domicilio, telefono)
        {
            this.numeroPedido = nroPedido;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Setter / Getter gustoHelado
        /// </summary>
        public EHelado Gusto
        {
            get { return this.gustoHelado; }

            set { this.gustoHelado = value; }

        }

        /// <summary>
        /// Setter / Getter numero pedido
        /// </summary>
        public string NumeroPedido
        {
            get { return this.numeroPedido; }

            set { this.numeroPedido = value; }

        }

        /// <summary>
        /// Setter / Getter delivery
        /// </summary>
        public EEnvio ConEnvio
        {
            get { return this.conEnvio; }

            set { this.conEnvio = value; }
        }

        /// <summary>
        /// Setter / Getter domicilioEntrega
        /// </summary>
        public string DomicilioEntrega
        {
            get { return this.domicilioEntrega; }

            set { this.domicilioEntrega = value; }
        }

        /// <summary>
        /// Setter / Getter telefonoEntrega
        /// </summary>
        public string TelefonoEntrega
        {
            get { return this.telefonoEntrega; }

            set { this.telefonoEntrega = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga ToString()
        /// </summary>
        /// <returns>retorna todos los datos del objetos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pedido Nro.: {this.numeroPedido}");
            sb.AppendLine($"Item: Helado de {this.gustoHelado.ToString()}");
            sb.AppendLine($"Direccion: {this.domicilioEntrega}");
            sb.AppendLine($"TelefonoEntrega: {this.telefonoEntrega}");

            return sb.ToString();
        }

        /// <summary>
        /// Impime ticket con los datos del pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>true si se imprimio, false caso contrario</returns>
        public static bool PrintTicket(Pedido pedido)
        {
            bool retorno = false;
            string path;

            if (pedido != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, pedido.numeroPedido.ToString());

                Texto texto = new Texto();

                texto.Guardar(path, pedido.ToString());
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
