﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Ventas
    {
        private List<Clientes> clientess = new List<Clientes>();
        private List<Producto> productos = new List<Producto>();

        public List<Clientes> clientes { get => clientess; set => clientess = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        public Ventas()
        {
            this.clientes = clientes;
            this.Productos = Productos;
        }

        public bool AgregarCliente(string name, string surname, string nacionality, string rut, DateTime birthdate)
        {
            Clientes cliente = new Clientes(name, surname, nacionality, rut, birthdate);
            for (int i = 0; i < clientes.Count; i++)
            {
                if (cliente.VerPersona() == clientes[i].VerPersona())
                {
                    Console.WriteLine("\nEl cliente ya existe");
                    return false;
                }
                else
                {
                    continue;
                }
            }
            clientes.Add(cliente);
            return true;
        }
        public bool CrearProducto(string name, string brand, int price, int stock)
        {
            Producto producto = new Producto(name, brand, price, stock);
            for (int i = 0; i < Productos.Count; i++)
            {
                if (producto.ValidarProducto() == Productos[i].ValidarProducto())
                {
                    Console.WriteLine("\nEl producto ya existe");
                    return false;
                }
                else
                {
                    continue;
                }
            }
            Productos.Add(producto);
            return true;
        }

        public void VerProductos()
        {
            Console.WriteLine("\nLos Productos que el supermercado tiene son: ");
            for (int i = 1; i < Productos.Count + 1; i++)
            {
                Console.WriteLine("\nOpción (" + i + "):");
                Console.WriteLine(Productos[i - 1].InformacionProducto());
            }
        }

        public void VerClientes()
        {
            Console.WriteLine("\nLos Clientes en el supermercado son: ");
            for (int i = 1; i < clientes.Count + 1; i++)
            {
                Console.WriteLine("\nOpción (" + i + "):");
                Console.WriteLine(clientes[i - 1].VerPersona());
            }
        }

        public List<Producto> AgregarAlCarro()
        {
            List<Producto> carro = new List<Producto>();
            Console.WriteLine("\nSeleccione el producto que desee:");
            VerProductos();
            int choose1 = Int32.Parse(Console.ReadLine());
            Producto producto1 = productos[choose1 - 1];
            Console.WriteLine("En que cantidad lo quiere:");
            int cantidad1 = Int32.Parse(Console.ReadLine());
            int diferencia1 = producto1.Stock - cantidad1;
            if (diferencia1 >= 0)
            {
                for (int i = 0; i < cantidad1; i++)
                {
                    carro.Add(producto1);
                    producto1.Stock = diferencia1;
                }
            }
            else
            {
                Console.WriteLine("No se puede agegar el producto/s al carro por que no hay suficiente stock");
            }
            while (true)
            {
                Console.WriteLine("\nDesea Seleccionar Otro producto ( (a)si , (b)no )");
                string folow = Console.ReadLine();
                if (folow == "a")
                {
                    VerProductos();
                    int choose2 = Int32.Parse(Console.ReadLine());
                    Producto producto2 = productos[choose2 - 1];
                    Console.WriteLine("En que cantidad lo quiere:");
                    int cantidad2 = Int32.Parse(Console.ReadLine());
                    int diferencia2 = producto2.Stock - cantidad2;
                    if (diferencia2 >= 0)
                    {
                        for (int i = 0; i < cantidad2; i++)
                        {
                            carro.Add(producto2);
                            producto2.Stock = diferencia2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo se puede agegar el producto/s al carro por que no hay suficiente stock");
                    }
                }
                else if (folow == "b")
                {
                    Console.WriteLine("\nLos Productos seleccionados son: ");
                    for (int i = 0; i < carro.Count; i++)
                    {
                        Console.WriteLine("\n" + carro[i].InformacionProducto());
                    }
                    return carro;
                }
                else
                {
                    Console.WriteLine("No es opción válida, por favor seleccione una que si lo sea");
                }
            }
        }

        public void ModificarStock()
        {
            Console.WriteLine("Seleccione el producto que desea modificar");
            VerProductos();
            int choose2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la nueva cantidad:");
            int cantidad2 = Int32.Parse(Console.ReadLine());
            productos[choose2 - 1].Stock = cantidad2;
        } 
    }
}
