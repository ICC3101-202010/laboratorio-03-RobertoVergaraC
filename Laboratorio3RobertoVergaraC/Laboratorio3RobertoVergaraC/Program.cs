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
                if (option == "a")
                {

                }
                else if (option == "b")
                {

                }
                else if (option == "c")
                {

                }
                else if (option == "d")
                {

                }
                else if (option == "e")
                {

                }
                else if (option == "f")
                {

                }
                else if (option == "g")
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
