using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        #region Propiedades 
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }
        #endregion


        private Persona()
        {
            this.dni = 00000000;
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
        }
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public virtual string MostrarPersona()
        {
            return string.Format($"El nombre es: {this.nombre} y el apellido es {this.apellido} cuyo dni es : {this.dni}");

        }

    
       

    }



}
