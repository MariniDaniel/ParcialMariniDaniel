using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            Clientes cliente = new Clientes("Daniel", "Marinito", 5446546);
            Empleados empleado = new Empleados("lauty", "malo", 788989);
            Producto producto1 = new Producto("CERVEZA DUFF", 50, 20, 001);
            Producto producto2 = new Producto("PAPITAS", 70, 15, 002);


            TiendaApu tiendaApu = new TiendaApu(cliente, empleado);

            tiendaApu.productos.Add(producto1);
            tiendaApu.productos.Add(producto2);

            Console.WriteLine(tiendaApu.CompraTienda());
            Console.ReadLine();








        }
    }
}
