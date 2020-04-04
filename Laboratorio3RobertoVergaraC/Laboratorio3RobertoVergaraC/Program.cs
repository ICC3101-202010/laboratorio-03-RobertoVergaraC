using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Supermercado, seleccione que opción desea realizar");
            int contador = 1;
            while (contador != 0)
            {
                Console.WriteLine("\n(a) Agregar Trabajador\n(b) Subir/Bajar Sueldo a Trabajador\n(c) Subir/Bajar Rango a Trabajador\n(d) Agregar Cliente\n(e) Comprar con un cliente\n(f) Agregar Producto\n(g) Salir del programa\n");
                string option = Console.ReadLine();
                if (option == "a") //Agregar Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el apellido del trabajador:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Seleccione la nacionalidad del trabajador:");
                    string nacionality = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Seleccione la fecha de nacimiento del trabajador (año-mes-día):");
                    string date = Console.ReadLine();
                    DateTime birthday = DateTime.Parse(date);
                    Console.WriteLine("Seleccione el cargo para el trabajador ((1)jefe,(2)supervisor,(3)cajero,(4)reponedor,(5)auxiliar):");
                    string status = Console.ReadLine();
                    Console.WriteLine("Seleccione el salario que desea para el trabajador:");
                    int salary = Int32.Parse(Console.ReadLine());
                }
                else if (option == "b") //Subir/Bajar Sueldo a Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Seleccione el nuevo salario que desea para el trabajador:"); //Agregar saalrio actual
                    int salary = Int32.Parse(Console.ReadLine());
                }
                else if (option == "c") //Subir/Bajar Rango al Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Seleccione el nuevo cargo que desea para el trabajador ((1)jefe,(2)supervisor,(3)cajero,(4)reponedor,(5)auxiliar):"); //Agregar puesto actual
                    string status = Console.ReadLine();
                }
                else if (option == "d") //Agregar Cliente
                {
                    Console.WriteLine("\nSeleccione el nombre del cliente:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el apellido del cliente:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Seleccione la nacionalidad del cliente:");
                    string nacionality = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del cliente:");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Seleccione la fecha de nacimiento del cliente (año-mes-día):");
                    string date = Console.ReadLine();
                    DateTime birthday = DateTime.Parse(date);
                }
                else if (option == "e") //Comprar con un cliente
                {

                }
                else if (option == "f") //Agregar Producto
                {
                    Console.WriteLine("\nSeleccione el nombre del producto que quiere agregar:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione la marca del producto que quiere agregar:");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Seleccione el precio del producto que quiere agregar:");
                    int price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione la cantidad del producto que quiere agregar:");
                    int stock = Int32.Parse(Console.ReadLine());
                }
                else if (option == "g") //Salir del programa
                {
                    contador = 0;
                }
                else
                {
                    Console.WriteLine("\nLa opción que seleccionó no es válida, por favor escoga una que si lo sea");
                }
            }
        }
    }
}
