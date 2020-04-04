using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Reponedores : Trabajadores
    {
        public Reponedores(int salary, string schedule, string name, string surname, string nacionality, string rut, DateTime birthdate) : base(salary, schedule, name, surname, nacionality, rut, birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nacionality = nacionality;
            this.Rut = rut;
            this.Birthdate = birthdate;

            this.Salary = salary;
            this.Schedule = schedule;
            this.Status = 4;
        }
    }
}
