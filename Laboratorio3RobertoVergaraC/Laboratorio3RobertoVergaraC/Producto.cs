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

        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(string name, string brand, int price, int stock)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Stock = stock;
        }

        public string ValidarProducto()
        {
            return "Nombre: " + this.Name + "\nMarca: " + this.Brand;
        }

        public string InformacionProducto()
        {
            return "Nombre: " + this.Name + "\nMarca: " + this.Brand + "\nPrecio: " + this.Price + "\nStock: " + this.Stock;
        }
    }
}
