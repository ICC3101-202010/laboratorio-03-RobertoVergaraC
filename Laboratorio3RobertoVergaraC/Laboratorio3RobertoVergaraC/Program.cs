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
            Administrativo admin = new Administrativo();
            Ventas ventas = new Ventas();
            int contador = 1;
            while (contador != 0)
            {
                Console.WriteLine("\n(a) Agregar Trabajador\n(b) Subir/Bajar Sueldo a Trabajador\n(c) Subir/Bajar Rango a Trabajador\n(d) Cambiar horario a Trabajador\n(e) Ver todos los Trabajadores\n(f) Agregar Cliente\n(g) Comprar con un cliente (recuerde que para poder comprar, antes tiene que haber creado por lo menos 1 cajero para que lo puedan atender)\n(h) Agregar Producto\n(i) Modificar Stock de Algún Producto\n(j) Salir del programa\n");
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
                    Console.WriteLine("Seleccione el horario para el trabajador (hora inicio-hora fin):");
                    string schedule = Console.ReadLine();
                    Console.WriteLine("Seleccione el salario que desea para el trabajador (int):");
                    int salary = Int32.Parse(Console.ReadLine());
                    admin.AgregarTrabajador(status, salary, schedule, name, surname, nacionality, rut, birthday);
                }
                else if (option == "b") //Subir/Bajar Sueldo a Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Trabajadores worker = admin.IdentificarObjeto(name, rut);
                    Console.WriteLine("Seleccione el nuevo sueldo que quiera para el trabajador (Sueldo actual " + worker.Salary + "):");
                    int salary = Int32.Parse(Console.ReadLine());
                    admin.CambiarSueldo(worker, salary);
                }
                else if (option == "c") //Subir/Bajar Rango al Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Seleccione el nuevo cargo que desea para el trabajador ((1)jefe,(2)supervisor,(3)cajero,(4)reponedor,(5)auxiliar):");
                    string status = Console.ReadLine();
                    Trabajadores worker = admin.IdentificarObjeto(name, rut);
                    admin.CambiarRango(worker, status);
                }
                else if (option == "d") //Cambiar horario Trabajador
                {
                    Console.WriteLine("\nSeleccione el nombre del trabajador:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el rut del trabajador:");
                    string rut = Console.ReadLine();
                    Trabajadores worker = admin.IdentificarObjeto(name, rut);
                    Console.WriteLine("Seleccione el nuevo horario que desea (Horario actual: " + worker.Schedule + "):");
                    string schedule = Console.ReadLine();
                    admin.CambiarHorario(worker, schedule);
                }
                else if (option == "e") //Ver todos los Trabajadores
                {
                    admin.VerTrabajadores();
                }
                else if (option == "f") //Agregar Cliente
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
                    DateTime birthdate = DateTime.Parse(date);
                    ventas.AgregarCliente(name, surname, nacionality, rut, birthdate);
                }
                else if (option == "g") //Comprar con un cliente
                {
                    Console.WriteLine("\nSeleccione el cliente que desee:");
                    ventas.VerClientes();
                    int choose = Int32.Parse(Console.ReadLine());
                    Clientes cliente = ventas.clientes[choose - 1];
                    List<Producto> carro = ventas.AgregarAlCarro();
                    int contador1 = 0;
                    Console.WriteLine("\n--------BOLETA--------\n\n");
                    Console.WriteLine("Cliente :\n" + cliente.VerPersona());
                    Console.WriteLine("Fecha y hora de la Compra: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    Console.WriteLine("Fue atendido en: " + admin.Cajero());
                    Console.WriteLine("El cajero que lo atendió fue:");
                    Console.WriteLine(admin.CajeroPersona());
                    Console.WriteLine("Los productos que se compraron son:");
                    for (int i = 0; i < carro.Count; i++)
                    {
                        Console.WriteLine("\n" + carro[i].InformacionProducto2());
                        contador1 += carro[i].Price;
                    }
                    Console.WriteLine("\nPrecio Total: " + contador1);
                    Console.WriteLine("\n\n--------FIN BOLETA--------");
                }
                else if (option == "h") //Agregar Producto
                {
                    Console.WriteLine("\nSeleccione el nombre del producto que quiere agregar:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione la marca del producto que quiere agregar:");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Seleccione el precio del producto que quiere agregar:");
                    int price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione la cantidad del producto que quiere agregar:");
                    int stock = Int32.Parse(Console.ReadLine());
                    ventas.CrearProducto(name, brand, price, stock);
                }
                else if (option == "i") //Modificar Stock de algún producto
                {
                    ventas.ModificarStock();
                }
                else if (option == "j") //Salir del programa
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
