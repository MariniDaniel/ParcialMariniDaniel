using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes : Persona
    {
       

        [DisplayName("Nombre")]
        public string NombreCliente
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DisplayName("Apellido")]
        public string ApellidoCliente
        {
            get { return apellido; }
            set { apellido = value; }
        }

        [DisplayName("Documento")]
        public int DniCliente
        {
            get { return dni; }
            set { dni = value; }
        }

        public Clientes(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
           

        }



        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga operador ==
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="auxCliente"></param>
        /// <returns></returns>
        public static bool operator ==(List<Clientes> listaClientes, Clientes auxCliente)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].dni == auxCliente.dni)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga operador !=
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="auxCliente"></param>
        /// <returns></returns>
        public static bool operator !=(List<Clientes> listaClientes, Clientes auxCliente)
        {
            return !(listaClientes == auxCliente);
        }

        #endregion
    }
}
