using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Cajeros : Trabajadores
    {
        public Cajeros(double salary, double hours, int status, string name, string surname, string nacionality, string rut, DateTime birthdate) : base(salary, hours, status, name, surname, nacionality, rut, birthdate)
        {
            this.name = name;
            this.surname = surname;
            this.nacionality = nacionality;
            this.rut = rut;
            this.birthdate = birthdate;

            this.salary = salary;
            this.hours = hours;
            this.status = status;
        }
    }
}
