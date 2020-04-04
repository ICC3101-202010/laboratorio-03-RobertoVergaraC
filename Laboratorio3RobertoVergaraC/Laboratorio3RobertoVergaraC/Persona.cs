using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    public class Persona
    {
        private string name;
        private string surname;
        private string nacionality;
        private string rut;
        private DateTime birthdate;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Nacionality { get => nacionality; set => nacionality = value; }
        public string Rut { get => rut; set => rut = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        public Persona(string name, string surname, string nacionality, string rut, DateTime birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nacionality = nacionality;
            this.Rut = rut;
            this.Birthdate = birthdate;
        }
    }
}
