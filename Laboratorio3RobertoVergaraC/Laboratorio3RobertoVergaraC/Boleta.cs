using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Boleta
    {
        private int ticketNumber;
        private DateTime date;
        private List<Producto> productosComprados = new List<Producto>();

        public Boleta(int ticketNumber, DateTime date, List<Producto> productosComprados)
        {
            this.ticketNumber = ticketNumber;
            this.date = date;
            this.productosComprados = productosComprados;
        }

    }
}
