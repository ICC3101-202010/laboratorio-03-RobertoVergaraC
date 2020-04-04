using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    public class Trabajadores : Persona
    {
        protected int salary;    //cuanto ganan 
        protected string schedule;     //horas trabajadas --> no son horas es horario
        protected int status;       //jefe=1; supervisores=2, cajeros=3, reponedores=4, Auxiliares=5

        public Trabajadores(int salary, string schedule, string name, string surname, string nacionality, string rut, DateTime birthdate) : base(name, surname, nacionality, rut, birthdate)
        {
            this.name = name;
            this.surname = surname;
            this.nacionality = nacionality;
            this.rut = rut;
            this.birthdate = birthdate;

            this.salary = salary;
            this.schedule = schedule;
        }

        public string VerTrabajador()
        {
            return "Nombre: " + this.name + "\nApellido: " + this.surname + "\nNacionalidad: " + this.nacionality + "\nRut: " + this.rut + "\nFecha Nacimiento: " + this.birthdate;
        }

        public string VerInfoTrabajador()
        {
            return "Salario: " + this.salary + "\nHorario: " + this.schedule;
        }
    }
}
