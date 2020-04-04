using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3RobertoVergaraC
{
    class Administrativo
    {
        private List<Jefes> jefes = new List<Jefes>();
        private List<Supervisores> supervisores = new List<Supervisores>();
        private List<Cajeros> cajeros = new List<Cajeros>();
        private List<Reponedores> reponedores = new List<Reponedores>();
        private List<Auxiliares> auxiliares = new List<Auxiliares>();

        public bool AgregarTrabajador(string status, int salary, string schedule, string name, string surname, string nacionality, string rut, DateTime birthdate)
        {
            if (status == "1")
            {
                Jefes jefe = new Jefes(salary, schedule, name, surname, nacionality, rut, birthdate);
                for (int i = 0; i < jefes.Count; i++)
                {
                    if (jefe.VerPersona() == jefes[i].VerPersona())
                    {
                        Console.WriteLine("\nEl trabajador ya existe");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                jefes.Add(jefe);
                return true;
            }
            else if (status == "2")
            {
                Supervisores supervisor = new Supervisores(salary, schedule, name, surname, nacionality, rut, birthdate);
                for (int i = 0; i < supervisores.Count; i++)
                {
                    if (supervisor.VerPersona() == jefes[i].VerPersona())
                    {
                        Console.WriteLine("\nEl trabajador ya existe");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                supervisores.Add(supervisor);
                return true;
            }
            else if (status == "3")
            {
                Cajeros cajero = new Cajeros(salary, schedule, name, surname, nacionality, rut, birthdate);
                for (int i = 0; i < cajeros.Count; i++)
                {
                    if (cajero.VerPersona() == cajeros[i].VerPersona())
                    {
                        Console.WriteLine("\nEl trabajador ya existe");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                cajeros.Add(cajero);
                return true;
            }
            else if (status == "4")
            {
                Reponedores reponedor = new Reponedores(salary, schedule, name, surname, nacionality, rut, birthdate);
                for (int i = 0; i < reponedores.Count; i++)
                {
                    if (reponedor.VerPersona() == reponedores[i].VerPersona())
                    {
                        Console.WriteLine("\nEl trabajador ya existe");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                reponedores.Add(reponedor);
                return true;
            }
            else if (status == "5")
            {
                Auxiliares auxiliar = new Auxiliares(salary, schedule, name, surname, nacionality, rut, birthdate);
                for (int i = 0; i < auxiliares.Count; i++)
                {
                    if (auxiliar.VerPersona() == auxiliares[i].VerPersona())
                    {
                        Console.WriteLine("\nEl trabajador ya existe");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                auxiliares.Add(auxiliar);
                return true;
            }
            else
            {
                Console.WriteLine("\nEl valor que selecciono no es válido");
                return false;
            }
        }

        public void VerTrabajadores()
        {
            Console.WriteLine("\nLista de Jefes:");
            for (int i = 0; i < jefes.Count; i++)
            {
                Console.WriteLine(jefes[i].VerPersona());
            }
            Console.WriteLine("\nLista de Supervisores:");
            for (int i = 0; i < supervisores.Count; i++)
            {
                Console.WriteLine(supervisores[i].VerPersona());
            }
            Console.WriteLine("\nLista de Cajeros:");
            for (int i = 0; i < cajeros.Count; i++)
            {
                Console.WriteLine(cajeros[i].VerPersona());
            }
            Console.WriteLine("\nLista de Reponedores:");
            for (int i = 0; i < reponedores.Count; i++)
            {
                Console.WriteLine(reponedores[i].VerPersona());
            }
            Console.WriteLine("\nLista de Auxiliares:");
            for (int i = 0; i < auxiliares.Count; i++)
            {
                Console.WriteLine(auxiliares[i].VerPersona());
            }
        }

        public Trabajadores IdentificarObjeto(string name, string rut)
        {
            for (int i = 0; i < jefes.Count; i++)
            {
                if (jefes[i].NameplusRut() == "Nombre: " + name + "\nRut: " + rut)
                {
                    return jefes[i];
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (supervisores[i].NameplusRut() == "Nombre: " + name + "\nRut: " + rut)
                {
                    return supervisores[i];
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (cajeros[i].NameplusRut() == "Nombre: " + name + "\nRut: " + rut)
                {
                    return cajeros[i];
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (reponedores[i].NameplusRut() == "Nombre: " + name + "\nRut: " + rut)
                {
                    return reponedores[i];
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (auxiliares[i].NameplusRut() == "Nombre: " + name + "\nRut: " + rut)
                {
                    return auxiliares[i];
                }
            }
            Console.WriteLine("\nEl trabajador no existe");
            return null;
        }

        public void CambiarSueldo(Trabajadores trabajador, int newSalary)
        {
            for (int i = 0; i < jefes.Count; i++)
            {
                if (trabajador.VerPersona() == jefes[i].VerPersona())
                {
                    jefes[i].Salary = newSalary;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(jefes[i].VerPersona());
                    Console.WriteLine(jefes[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (trabajador.VerPersona() == supervisores[i].VerPersona())
                {
                    supervisores[i].Salary = newSalary;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(supervisores[i].VerPersona());
                    Console.WriteLine(supervisores[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (trabajador.VerPersona() == cajeros[i].VerPersona())
                {
                    cajeros[i].Salary = newSalary;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(cajeros[i].VerPersona());
                    Console.WriteLine(cajeros[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (trabajador.VerPersona() == reponedores[i].VerPersona())
                {
                    reponedores[i].Salary = newSalary;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(reponedores[i].VerPersona());
                    Console.WriteLine(reponedores[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (trabajador.VerPersona() == auxiliares[i].VerPersona())
                {
                    auxiliares[i].Salary = newSalary;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(auxiliares[i].VerPersona());
                    Console.WriteLine(auxiliares[i].VerInfoTrabajador());
                }
            }

        }

        public void CambiarRango(Trabajadores trabajador, string newStatus)
        {
            for (int i = 0; i < jefes.Count; i++)
            {
                if (trabajador.VerPersona() == jefes[i].VerPersona())
                {
                    jefes.Remove(jefes[i]);
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (trabajador.VerPersona() == supervisores[i].VerPersona())
                {
                    supervisores.Remove(supervisores[i]);
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (trabajador.VerPersona() == cajeros[i].VerPersona())
                {
                    cajeros.Remove(cajeros[i]);
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (trabajador.VerPersona() == reponedores[i].VerPersona())
                {
                    reponedores.Remove(reponedores[i]);
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (trabajador.VerPersona() == auxiliares[i].VerPersona())
                {
                    auxiliares.Remove(auxiliares[i]);
                }
            }
            if (newStatus == "1") { jefes.Add(new Jefes(trabajador.Salary, trabajador.Schedule, trabajador.Name, trabajador.Surname, trabajador.Nacionality, trabajador.Rut, trabajador.Birthdate)); }
            else if (newStatus == "2") { supervisores.Add(new Supervisores(trabajador.Salary, trabajador.Schedule, trabajador.Name, trabajador.Surname, trabajador.Nacionality, trabajador.Rut, trabajador.Birthdate)); }
            else if (newStatus == "3") { cajeros.Add(new Cajeros(trabajador.Salary, trabajador.Schedule, trabajador.Name, trabajador.Surname, trabajador.Nacionality, trabajador.Rut, trabajador.Birthdate)); }
            else if (newStatus == "4") { reponedores.Add(new Reponedores(trabajador.Salary, trabajador.Schedule, trabajador.Name, trabajador.Surname, trabajador.Nacionality, trabajador.Rut, trabajador.Birthdate)); }
            else if (newStatus == "5") { auxiliares.Add(new Auxiliares(trabajador.Salary, trabajador.Schedule, trabajador.Name, trabajador.Surname, trabajador.Nacionality, trabajador.Rut, trabajador.Birthdate)); }

        }
   
        public void CambiarHorario(Trabajadores trabajador, string newSchedule)
            {
            for (int i = 0; i < jefes.Count; i++)
            {
                if (trabajador.VerPersona() == jefes[i].VerPersona())
                {
                    jefes[i].Schedule = newSchedule;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(jefes[i].VerPersona());
                    Console.WriteLine(jefes[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (trabajador.VerPersona() == supervisores[i].VerPersona())
                {
                    supervisores[i].Schedule = newSchedule;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(supervisores[i].VerPersona());
                    Console.WriteLine(supervisores[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (trabajador.VerPersona() == cajeros[i].VerPersona())
                {
                    cajeros[i].Schedule = newSchedule;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(cajeros[i].VerPersona());
                    Console.WriteLine(cajeros[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (trabajador.VerPersona() == reponedores[i].VerPersona())
                {
                    reponedores[i].Schedule = newSchedule;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(reponedores[i].VerPersona());
                    Console.WriteLine(reponedores[i].VerInfoTrabajador());
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (trabajador.VerPersona() == auxiliares[i].VerPersona())
                {
                    auxiliares[i].Schedule = newSchedule;
                    Console.WriteLine("\nLa información del Trabajador se cambió a:");
                    Console.WriteLine(auxiliares[i].VerPersona());
                    Console.WriteLine(auxiliares[i].VerInfoTrabajador());
                }
            }
        }
    }
}
