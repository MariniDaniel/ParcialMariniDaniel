using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados : Persona
    {
        int idEmpleado;
        string usuario;




        #region Constructor
        /// <summary>
        /// Constructor Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="idEmpleado"></param>
        /// <param name="usuario"></param>
        public Empleados(string nombre, string apellido, int dni,int idEmpleado,string usuario) : base(nombre, apellido, dni)
        {
            this.idEmpleado = idEmpleado;
            this.usuario = usuario;
        }
        #endregion



        public override string MostrarPersona()
        {
            return base.MostrarPersona() + this.idEmpleado;
        }


        #region Properties
        /// <summary>
        /// Getter idEmpleado
        /// </summary>
        public int IdEmpleado
        {
            get { return this.idEmpleado; }
        }

        public string Usuario
        {
            get { return this.usuario; }
        }

        #endregion


    }
}
