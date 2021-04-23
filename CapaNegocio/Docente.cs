using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int dni;
        private DateTime fechaNacimiento;
        private string profesion;
        // Propiedades
        public string Apellidos
        {
            get { return apellidos; } //Lectura del atributo
            set { apellidos = value; } //Escritura del atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return this.profesion; }
            set { this.profesion = value; }
        }
        // Metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }

    }
}
