using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    public class Trabajadores : Persona
    {
        private int salary;    //cuanto ganan 
        private string schedule;     //horas trabajadas --> no son horas es horario
        private int status;       //jefe=1; supervisores=2, cajeros=3, reponedores=4, Auxiliares=5

        public int Salary { get => salary; set => salary = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public int Status { get => status; set => status = value; }

        public Trabajadores(int salary, string schedule, string name, string surname, string nacionality, string rut, DateTime birthdate) : base(name, surname, nacionality, rut, birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nacionality = nacionality;
            this.Rut = rut;
            this.Birthdate = birthdate;

            this.Salary = salary;
            this.Schedule = schedule;
        }

        public string VerTrabajador()
        {
            return "Nombre: " + this.Name + "\nApellido: " + this.Surname + "\nNacionalidad: " + this.Nacionality + "\nRut: " + this.Rut + "\nFecha Nacimiento: " + this.Birthdate;
        }

        public string VerInfoTrabajador()
        {
            return "Salario: " + this.Salary + "\nHorario: " + this.Schedule;
        }

        public string NameplusRut()
        {
            return "Nombre: " + this.Name + "\nRut: " + this.Rut;
        }
    }
}
