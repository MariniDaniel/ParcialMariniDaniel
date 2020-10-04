using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombreProducto;
        private float precioProducto;
        private int stock;
        private int idProducto;


        [DisplayName("Nombre")]
        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        [DisplayName("Precio")]
        public float PrecioProducto
        {
            get { return precioProducto; }
            set { precioProducto = value; }
        }

        [DisplayName("ID ")]
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        [DisplayName("Stock")]
        public int Stock
        {
            get { return stock; }

            set
            {
                stock = value;

                if (stock < 0)
                {
                    stock = 0;
                }
            }
        }


        public Producto(string nombreProducto, float precioProducto, int stock)
        {
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stock = stock;
            this.idProducto = 000;
        }


        public Producto(string nombreProducto, float precioProducto, int stock, int idProducto) : this(nombreProducto,precioProducto,stock)
        {
            this.idProducto = idProducto;
        }

        public Producto()
        {

        }
        public static string Mostrar(Producto producto1)
        {
            return "Nombre: " + producto1.nombreProducto.ToString() + " -- " + "Precio: " + producto1.precioProducto.ToString() + " -- " + "Stock: " + producto1.stock.ToString() + " -- " + "Codigo De Barras: " + producto1.idProducto.ToString();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Nombre de Producto:   {0} cm\n", this.nombreProducto);
            s.AppendFormat("Código De Barras:  {0}\n", this.idProducto.ToString());
            s.AppendFormat("Precio: ${0:0.00}\n", this.precioProducto);
            s.AppendFormat("Stock: {0} unidades", this.stock.ToString());
            return s.ToString();
        }



    }










}

