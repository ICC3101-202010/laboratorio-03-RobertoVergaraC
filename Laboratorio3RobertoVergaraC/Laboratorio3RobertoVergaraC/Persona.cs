﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    public class Persona
    {
        protected string name;
        protected string surname;
        protected string nacionality;
        protected string rut;
        protected DateTime birthdate;

        public Persona(string name, string surname, string nacionality, string rut, DateTime birthdate)
        {
            this.name = name;
            this.surname = surname;
            this.nacionality = nacionality;
            this.rut = rut;
            this.birthdate = birthdate;
        }
    }
}
