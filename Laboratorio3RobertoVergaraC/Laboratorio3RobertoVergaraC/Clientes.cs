using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Clientes : Persona
    {
        public Clientes(string name, string surname, string nacionality, string rut, DateTime birthdate) : base(name, surname, nacionality, rut, birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nacionality = nacionality;
            this.Rut = rut;
            this.Birthdate = birthdate;
        }
    }
}
