using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class ManejadorSQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        static ManejadorSQL()
        {
            try
            {

                conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=SegundoParcial ; Integrated Security=True;";
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Ejecuta ExecuteNonQuery() en una conexion SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>True si se ejecuto, false caso contrario</returns>
        public static bool EjecutarNonQuery(string sql)
        {
            bool ejecuto = false;
            try
            {
                comando.CommandText = sql;

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw new ArchivosException("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }

        /// <summary>
        /// Inserta un pedido a la base de datos
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public static bool InsertarPedido(Pedido pedido)
        {
            string sql = "Insert into HeladosYa([gustoHelado], [numeroPedido], [conEnvio], [domicilioEntrega], [telefonoEntrega]) "
                                     + "values(@auxGusto, @auxNumero, @auxEnvio, @auxDomicilio, @auxTelefono)";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@auxGusto", pedido.Gusto.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxNumero", pedido.NumeroPedido));
            comando.Parameters.Add(new SqlParameter("@auxEnvio", pedido.ConEnvio.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxDomicilio", pedido.DomicilioEntrega));
            comando.Parameters.Add(new SqlParameter("@auxTelefono", pedido.TelefonoEntrega));

            return EjecutarNonQuery(sql);
        }

        #endregion
    }
}
