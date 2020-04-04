using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Producto
    {
        private string name;
        private string brand;
        private int price;
        private int stock;

        public Producto(string name, string brand, int price, int stock)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.stock = stock;
        }

        public string InformacionProducto()
        {
            return "Nombre: " + this.name + "\nMarca: " + this.brand + "\nPrecio: " + this.price + "\nStock: " + this.stock + "\n";
        }
    }
}
