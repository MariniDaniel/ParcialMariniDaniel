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

       

       
    }
}
