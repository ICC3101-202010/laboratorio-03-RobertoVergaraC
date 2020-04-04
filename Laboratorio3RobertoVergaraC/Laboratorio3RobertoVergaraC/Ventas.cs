using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Ventas
    {
        private List<Clientes> clientes = new List<Clientes>();
        private List<Producto> productos = new List<Producto>();

        public void VerProductos()
        {
            Console.WriteLine("\nLos Productos que el supermercado son: ");
            for (int i=0; i<productos.Count;i++)
            {
                Console.WriteLine(productos[i].InformacionProducto());
            }
        }
    }
}
