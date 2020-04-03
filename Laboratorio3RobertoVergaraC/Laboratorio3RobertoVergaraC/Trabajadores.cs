using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    public class Trabajadores : Persona
    {
        protected double salary;    //cuanto ganan 
        protected double hours;     //horas trabajadas
        protected int status;       //jefe=1; supervisores=2, cajeros=3, reponedores=4, Auxiliares=5

        public Trabajadores(double salary, double hours,int status, string name, string surname, string nacionality, string rut, DateTime birthdate) : base(name, surname, nacionality, rut, birthdate)
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
