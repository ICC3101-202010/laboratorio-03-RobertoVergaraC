﻿using System;
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
            this.name = name;
            this.surname = surname;
            this.nacionality = nacionality;
            this.rut = rut;
            this.birthdate = birthdate;

            this.salary = salary;
            this.schedule = schedule;
            this.status = 4;
        }
    }
}
