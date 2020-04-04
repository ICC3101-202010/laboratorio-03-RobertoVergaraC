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
                    if (jefe.VerTrabajador() == jefes[i].VerTrabajador())
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
                    if (supervisor.VerTrabajador() == jefes[i].VerTrabajador())
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
                    if (cajero.VerTrabajador() == cajeros[i].VerTrabajador())
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
                    if (reponedor.VerTrabajador() == reponedores[i].VerTrabajador())
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
                    if (auxiliar.VerTrabajador() == auxiliares[i].VerTrabajador())
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
                Console.WriteLine(jefes[i].VerTrabajador());
            }
            Console.WriteLine("\nLista de Supervisores:");
            for (int i = 0; i < supervisores.Count; i++)
            {
                Console.WriteLine(supervisores[i].VerTrabajador());
            }
            Console.WriteLine("\nLista de Cajeros:");
            for (int i = 0; i < cajeros.Count; i++)
            {
                Console.WriteLine(cajeros[i].VerTrabajador());
            }
            Console.WriteLine("\nLista de Reponedores:");
            for (int i = 0; i < reponedores.Count; i++)
            {
                Console.WriteLine(reponedores[i].VerTrabajador());
            }
            Console.WriteLine("\nLista de Auxiliares:");
            for (int i = 0; i < auxiliares.Count; i++)
            {
                Console.WriteLine(auxiliares[i].VerTrabajador());
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
                if (trabajador.VerTrabajador() == jefes[i].VerTrabajador())
                {
                    jefes[i].Salary = newSalary;
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (trabajador.VerTrabajador() == supervisores[i].VerTrabajador())
                {
                    supervisores[i].Salary = newSalary;
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (trabajador.VerTrabajador() == cajeros[i].VerTrabajador())
                {
                    cajeros[i].Salary = newSalary;
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (trabajador.VerTrabajador() == reponedores[i].VerTrabajador())
                {
                    reponedores[i].Salary = newSalary;
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (trabajador.VerTrabajador() == auxiliares[i].VerTrabajador())
                {
                    auxiliares[i].Salary = newSalary;
                }
            }

        }

        public void CambiarRango(Trabajadores trabajador, string newStatus)
        {
            int status = Convert.ToInt32(newStatus);

        }

        public void CambiarHorario(Trabajadores trabajador,string newSchedule)
        {
            for (int i = 0; i < jefes.Count; i++)
            {
                if (trabajador.VerTrabajador() == jefes[i].VerTrabajador())
                {
                    jefes[i].Schedule = newSchedule;
                }
            }
            for (int i = 0; i < supervisores.Count; i++)
            {
                if (trabajador.VerTrabajador() == supervisores[i].VerTrabajador())
                {
                    supervisores[i].Schedule = newSchedule;
                }
            }
            for (int i = 0; i < cajeros.Count; i++)
            {
                if (trabajador.VerTrabajador() == cajeros[i].VerTrabajador())
                {
                    cajeros[i].Schedule = newSchedule;
                }
            }
            for (int i = 0; i < reponedores.Count; i++)
            {
                if (trabajador.VerTrabajador() == reponedores[i].VerTrabajador())
                {
                    reponedores[i].Schedule = newSchedule;
                }
            }
            for (int i = 0; i < auxiliares.Count; i++)
            {
                if (trabajador.VerTrabajador() == auxiliares[i].VerTrabajador())
                {
                    auxiliares[i].Schedule = newSchedule;
                }
            }
        }
    }
}
